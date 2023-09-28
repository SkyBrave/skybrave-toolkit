using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Move
{
    public class ConstantlyMoveForwardsComponent : MonoBehaviour
    {
        [Header("Parameters")]
        [SerializeField] private float moveSpeed;

        public void Update()
        {
            MoveTowardsDirection();
        }

        public void MoveTowardsDirection()
        {
            transform.position += moveSpeed * Time.deltaTime * transform.forward;
            DebugVisualizer();
        }

        private void DebugVisualizer()
        {
            UnityEngine.Debug.DrawRay(transform.position, transform.forward * moveSpeed, Color.blue);
        }
    }
}
