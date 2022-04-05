using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Melee.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(AnimatorController))]
    public class Movement : MonoBehaviour
    {
        #region inspector
        #region events

        [HideInInspector] public UnityEvent FacingDirectionChanged;
        [HideInInspector] public UnityEvent<string> StartedMoving;
        [HideInInspector] public UnityEvent<string> StoppedMoving;
        [HideInInspector] public UnityEvent Jumped;
        [HideInInspector] public UnityEvent EvadeStarted;
        [HideInInspector] public UnityEvent EvadeEnded;
        [HideInInspector] public UnityEvent LeftTheGround;
        [HideInInspector] public UnityEvent Landed;
        #endregion
        #region component references
        [Header("Components")]
        [SerializeField] private Rigidbody2D rb2;
        [SerializeField] private Transform groundCheck;
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private AnimatorController animatorController;
        [SerializeField] private TrailRenderer dashTrailRenderer;
        #endregion
        #region values
        [Header("Values")]
        [SerializeField] private float movementSpeed = 4.3f;
        [SerializeField] private float dashSpeed = 6.5f;
        [SerializeField] private float dashDuration = .2f;
        [SerializeField] private float dashCooldown = .7f;
        [SerializeField] private float baseJumpHeight = 7.5f;
        #endregion
        #region bools
        [Tooltip("Used to flip sprite.")]
        [SerializeField] private bool isFacingRight = true;
        [SerializeField] private bool canDash = true;
        private bool isDashing;
        #endregion
        #region animation
        [Header("Animation Parameters/Triggers")]
        [SerializeField] private string animStateInt = "AnimState";
        [SerializeField] private string jumpTrigger = "Jump";
        [SerializeField] private string evadeTrigger = "Evade";
        [SerializeField] private string groundedBool = "Grounded";
        [SerializeField] private string airSpeedFloat = "AirSpeed";
        [SerializeField] private int idleAnimState = 0;
        [SerializeField] private int runAnimState = 2;
        #endregion
        #endregion
        #region getters and setters
        public bool IsGrounded
        {
            get
            {
                return Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            }
        }
        public bool CanJump
        {
            get
            {
                return true;
            }
        }
        public bool IsMoving
        {
            get
            {
                return rb2.velocity.x > 0f || rb2.velocity.x < 0f;
            }
        }
        #endregion
        #region private references
        private float inputAxis;
        private float groundCheckRadius = .2f;
        private float normalGravity;
        #endregion
        #region event listeners
        public void OnMove(float input)
        {
            inputAxis = input;
        }

        public void OnJump()
        {
            Jump();
        }

        public void OnDash()
        {
            if (canDash && inputAxis != 0f)
            {
                StartCoroutine(Dash());
            }
        }

        private void OnFacingDirectionChange()
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
        #endregion
        #region unity methods

        private void Awake()
        {
            rb2 = GetComponent<Rigidbody2D>();
            animatorController = GetComponent<AnimatorController>();
            FacingDirectionChanged.AddListener(OnFacingDirectionChange);

            SubscribeMethods();
        }

        private void Start()
        {
            normalGravity = rb2.gravityScale;
        }

        private void Update()
        {
            if (IsMoving)
            {
                animatorController.SetParameter(animStateInt, runAnimState);
            }
            else
            {
                animatorController.SetParameter(animStateInt, idleAnimState);
            }
            Flip();
        }

        private void FixedUpdate()
        {
            if (isDashing) return;
            if (IsGrounded)
            {
                rb2.velocity = new Vector2(inputAxis * movementSpeed, rb2.velocity.y);
            }
        }
        #endregion
        #region coroutines

        private IEnumerator Dash()
        {
            StartDash();
            yield return new WaitForSeconds(dashDuration);
            EndDash();
        }

        private IEnumerator EnterDashCooldown()
        {
            yield return new WaitForSeconds(dashCooldown);
            canDash = true;
        }
        #endregion

        private void Flip()
        {
            if (isFacingRight && inputAxis < 0f || !isFacingRight && inputAxis > 0f)
            {
                FacingDirectionChanged.Invoke();
            }
        }

        private void Jump()
        {
            if (!IsGrounded) return;

            Jumped.Invoke();
            rb2.velocity = new Vector2(rb2.velocity.x, baseJumpHeight);
        }

        private void StartDash()
        {
            canDash = false;
            isDashing = true;
            rb2.gravityScale = 0f;
            rb2.velocity = new Vector2(transform.localScale.x * dashSpeed, 0f);
            dashTrailRenderer.emitting = true;
            EvadeStarted.Invoke();
        }

        private void EndDash()
        {
            dashTrailRenderer.emitting = false;
            rb2.gravityScale = normalGravity;
            rb2.velocity = new Vector2(0f, 0f);
            isDashing = false;
            EvadeEnded.Invoke();
            StartCoroutine(EnterDashCooldown());
        }

        private void SubscribeMethods()
        {
            EvadeStarted.AddListener(OnEvadeStarted);
            EvadeEnded.AddListener(OnEvadeEnded);
            Jumped.AddListener(OnJumped);
        }

        private void OnJumped()
        {
            animatorController.SetTrigger(jumpTrigger);
        }

        private void OnEvadeStarted()
        {
            animatorController.SetTrigger(evadeTrigger);
        }

        private void OnEvadeEnded()
        {
            //animatorController.ResetTrigger(evadeTrigger);
        }

        #region debug
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
        #endregion
    }

}

