using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Melee.Combat
{
    public class Hittable : MonoBehaviour
    {
        [HideInInspector] public UnityEvent<Attack> Hit;

        [SerializeField] private LayerMask damagingLayers;

        [SerializeField] private Transform hurtbox;

        private void OnTriggerEnter2D(Collider2D collision)
        {
        }
    }

}
