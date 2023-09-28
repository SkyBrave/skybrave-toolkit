using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Action
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
