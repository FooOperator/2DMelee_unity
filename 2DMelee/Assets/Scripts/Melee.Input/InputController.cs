using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Melee.Input
{
    public class InputController : MonoBehaviour
    {
        #region events
        [Header("Unity Events", order = 0)]
        public UnityEvent<float> Moved;
        public UnityEvent Jumped;
        public UnityEvent Dashed;
        public UnityEvent<string> Attacked;

        #endregion
        private PlayerControls playerControls;

        private void Awake()
        {
            playerControls = new PlayerControls();
            SubscribeMethods();
        }

        private void OnEnable()
        {
            playerControls.Enable();
        }

        private void OnDisable()
        {
            playerControls.Disable();
        }

        private void SubscribeMethods()
        {
            var grounded = playerControls.Grounded;

            grounded.Jump.performed += Jump_performed;
            grounded.Move.performed += Move_performed;
            grounded.Dash.performed += Dash_performed;
            grounded.LightAttack.performed += ctx => Attack_performed(ctx, nameof(grounded.LightAttack));
            grounded.HeavyAttack.performed += ctx => Attack_performed(ctx, nameof(grounded.HeavyAttack));
        }

        private void Dash_performed(InputAction.CallbackContext ctx)
        {
            if (Dashed != null) Dashed.Invoke();
        }

        private void Move_performed(InputAction.CallbackContext ctx)
        {
            if (Moved != null) Moved.Invoke(ctx.ReadValue<float>());
        }

        private void Jump_performed(InputAction.CallbackContext ctx)
        {
            if (Jumped != null) Jumped.Invoke();
        }

        private void Attack_performed(InputAction.CallbackContext ctx, string whichAttack)
        {
            if (Attacked != null) Attacked.Invoke(whichAttack);
        }
    }
}
