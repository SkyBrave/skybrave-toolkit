using UnityEngine;
using UnityEngine.Events;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components
{
    public class SelectObjectInTheWorldComponent : MonoBehaviour
    {
        [Header("References")]
        private Camera _camera;

        [Header("Logic")]
        [SerializeField] private UnityEvent onObjectSelected;
        [SerializeField] private UnityEvent onBehaviourFailed;
        
        private void Start()
        {
            _camera = Camera.main;
        }

        public void ShootRayFromCamera()
        {
            var ray = _camera.ScreenPointToRay(UnityEngine.Input.mousePosition);
            var ifHitSomething = Physics.Raycast(ray, maxDistance: 1000, hitInfo: out var hit);

            if (ifHitSomething)
            {
                GameObject objectToHit = hit.transform.gameObject;
                TrySelectObject(objectToHit, hit.point);
            }
        }

        private void TrySelectObject(GameObject objectToSelect, Vector3 selectionWorldPos)
        {
            if (objectToSelect.TryGetComponent(out SelectableObjectComponent selectableObject))
            {
                selectableObject.SelectObject(selectionWorldPos);
                onObjectSelected.Invoke();
            }
            else
            {
                onBehaviourFailed.Invoke();
            }
        }
    }
}
