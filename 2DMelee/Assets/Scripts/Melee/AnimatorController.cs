using UnityEngine;

namespace Melee
{
    public class AnimatorController : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        public void SetParameter(string id, object value = null)
        {
            Log(id, value);
            if (value.GetType() == typeof(int))
            {
                animator.SetInteger(id, (int)value);
            }
            else if (value.GetType() == typeof(float))
            {
                animator.SetFloat(id, (float)value);
            }
            else if (value.GetType() == typeof(bool))
            {
                animator.SetBool(id, (bool)value);
            }
        }

        private void Log(string id, object value = null)
        {
            Debug.Log($"Id: {id}\nValue: {value}");
        }

        public void SetTrigger(string id)
        {
            Log(id);
            animator.SetTrigger(id);
        }

        internal void ResetTrigger(string id)
        {
            Log(id);
            animator.ResetTrigger(id);
        }
    }
}