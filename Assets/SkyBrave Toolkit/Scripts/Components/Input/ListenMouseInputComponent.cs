using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Input
{
    public class ListenMouseInputComponent : MonoBehaviour
    {
        [SerializeField] private UnityEvent onMouseButtonLeftClicked;
        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                onMouseButtonLeftClicked.Invoke();
            }
        }
    }
}
