using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components
{
    public class TimerComponent : MonoBehaviour
    {
        
        [Header("Logic")]
        public float RemainingSeconds;
        [SerializeField] private UnityEvent _onTimerEnd;

        private void Update()
        {
            if (RemainingSeconds == 0f) return;
            
            RemainingSeconds -= Time.deltaTime;
            
            CheckForTimerEnd();
        }
        
        public void StartTimer(float duration)
        {
            if (RemainingSeconds > 0) return;
            
            RemainingSeconds = duration;
        }
        
        public void ResetTimer()
        {
            RemainingSeconds = 0;
        }
        
        private void CheckForTimerEnd()
        {
            if (RemainingSeconds > 0f) return;

            ResetTimer();
            _onTimerEnd.Invoke();
        }

    }
}
