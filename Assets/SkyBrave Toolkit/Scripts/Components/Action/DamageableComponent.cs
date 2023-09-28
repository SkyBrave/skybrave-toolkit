using System;
using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Action
{
    [RequireComponent(typeof(HealthComponent))]
    public class DamageableComponent : MonoBehaviour
    {
        private HealthComponent _healthComponent;

        private void Awake()
        {
            _healthComponent = GetComponent<HealthComponent>();
        }

        public void DealDamage(float damageAmount)
        {
            _healthComponent.ChangeHealthPoints(-MathF.Abs(damageAmount));
        }
    }
}
