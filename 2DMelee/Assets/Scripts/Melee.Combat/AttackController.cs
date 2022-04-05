using Melee;
using UnityEngine;

namespace Melee.Combat
{
    [RequireComponent(typeof(AnimatorController))]
    public class AttackController : MonoBehaviour
    {
        private AnimatorController animatorController;
        [SerializeField] private LayerMask hittableLayers;

        private void Awake()
        {
            animatorController = GetComponent<AnimatorController>();
        }

        public void OnAttack(string whichAttack)
        {
            Debug.Log(whichAttack);
            animatorController.SetTrigger(whichAttack);
        }
    }

}
