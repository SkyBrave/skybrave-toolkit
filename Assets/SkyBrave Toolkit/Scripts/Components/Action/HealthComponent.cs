using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Action
{
    public class HealthComponent : MonoBehaviour
    {
        [Header("Parameters")]
        [SerializeField] private float healthPoints = 100f;

        [Header("Logic")] 
        [SerializeField] private UnityEvent onHpZero;
        
        public void ChangeHealthPoints(float amountToChange)
        {
            healthPoints += amountToChange;

            if (healthPoints <= 0)
            {
                onHpZero.Invoke();
            }
        }
    }
}
