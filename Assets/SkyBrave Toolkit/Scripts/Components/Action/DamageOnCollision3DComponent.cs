using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Action
{
    [RequireComponent(typeof(Collider), typeof(Rigidbody))]
    public class DamageOnCollision3DComponent : MonoBehaviour
    {
        [Header("Parameters")]
        [SerializeField] private float damageAmount = 10f;

        [Header("Logic")]
        [SerializeField] private UnityEvent onDamageDealt;
        [SerializeField] private UnityEvent onBehaviourFailed;

        private void OnEnable()
        {
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            GameObject objectToHit = collision.gameObject;
            TryDamageObject(objectToHit);
        }

        private void TryDamageObject(GameObject objectToDamage)
        {
            if (objectToDamage.TryGetComponent(out DamageableComponent damageableObject))
            {
                damageableObject.DealDamage(damageAmount);
                onDamageDealt.Invoke();
            }
            else
            { 
                onBehaviourFailed.Invoke();
            }
        }
    }
}
