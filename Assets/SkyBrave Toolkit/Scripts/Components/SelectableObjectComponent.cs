using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components
{
    [RequireComponent(typeof(Collider))]
    public class SelectableObjectComponent : MonoBehaviour
    {
        [Header("Logic")] 
        public bool IsSelected;
        public Vector3 SelectionWorldPos;
        [SerializeField] private UnityEvent onSelected;

        public void SelectObject(Vector3 selectionWorldPos)
        {
            IsSelected = true;
            SelectionWorldPos = selectionWorldPos;
            onSelected.Invoke();
        }
    }
}
