using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components
{
    public class TriggerableComponent : MonoBehaviour
    {
        public UnityEvent OnTriggerEnterEvent;
        public UnityEvent OnTriggerStayEvent;
        public UnityEvent OnTriggerExitEvent;
        public UnityEvent OnTriggerEnter2DEvent;
        public UnityEvent OnTriggerStay2DEvent;
        public UnityEvent OnTriggerExit2DEvent;
        
        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterEvent.Invoke();
        }

        private void OnTriggerStay(Collider other)
        {
            OnTriggerStayEvent.Invoke();
        }

        private void OnTriggerExit(Collider other)
        {
            OnTriggerExitEvent.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            OnTriggerEnter2DEvent.Invoke();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            OnTriggerStay2DEvent.Invoke();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            OnTriggerExit2DEvent.Invoke();
        }
    }
}
