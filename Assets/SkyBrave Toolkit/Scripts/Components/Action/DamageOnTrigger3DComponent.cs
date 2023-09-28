using SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Debug;
using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Action
{
    [RequireComponent(typeof(Collider))]
    public class DamageOnTrigger3DComponent : MonoBehaviour
    {
        [Header("Parameters")]
        [SerializeField] private float damageAmount = 10f;
        
        [Header("Logic")]
        [SerializeField] private UnityEvent onDamageDealt;
        [SerializeField] private UnityEvent onBehaviourFailed;

        [Header("Settings")] 
        [SerializeField] private DebugLoggerComponent debugLoggerComponent;

        private void OnEnable()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            GameObject objectToHit = other.gameObject;
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
            
            Log("Will find ways to implement this to other scripts, maybe?");
        }

        private void Log(object message)
        {
            if (debugLoggerComponent) debugLoggerComponent.LogMessageWithSender(message, this);
        }
    }
}
