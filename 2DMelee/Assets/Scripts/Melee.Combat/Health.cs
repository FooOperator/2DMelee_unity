using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Melee.Combat
{

    
    public interface IKillable : IHittable
    {

        void TakeDamage();

        void Die();
    }

    public interface IHittable
    {
        void TakeHit();
    }

    public class Health : MonoBehaviour
    {
    }

}
