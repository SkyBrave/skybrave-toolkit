using UnityEngine;

namespace SkyBrave_Toolkit.Scripts.Components
{
    public class DestructibleComponent : MonoBehaviour
    {
        private void OnEnable()
        {
            
        }

        public void DisableObject()
        {
            gameObject.SetActive(false);
        }

        public void DestroyObject()
        {
            Destroy(gameObject);
        }
    }
}
