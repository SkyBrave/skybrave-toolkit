using UnityEngine;
using Random = UnityEngine.Random;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components
{
    public class VelocityComponent : MonoBehaviour
    {
        /* what the fuck do i want from this component?
         *
         * i want this to be able to calculate the desired velocity based on speed parameter, also applying the acceleration
         * i want this to be able to move objects using the velocity
         *
         * might consider adding 'maxSpeed modifiers to manipulate the speed'
         *
         * come back here if confused + inspiration: https://youtu.be/rCu8vQrdDDI?si=D9yF4w_qAqcTSyI1&t=389
         */

        public Vector3 Velocity;
        public float AccelerationCoefficient = 10f;
        public float AccelerationCoefficientMultiplier = 1f;
        public float MaxSpeed;
        
        private void AccelerateToVelocity(Vector3 targetVelocity)
        {
            Velocity = Vector3Damp(Velocity, targetVelocity, AccelerationCoefficient * AccelerationCoefficientMultiplier, Time.deltaTime);
        }

        public void AccelerateInDirection(Vector3 direction)
        {
            AccelerateToVelocity(MaxSpeed * direction);
        }

        public Vector3 GetMaxVelocity(Vector3 direction)
        {
            return MaxSpeed * direction;
        }

        public void MaximizeVelocity(Vector3 direction)
        {
            Velocity = GetMaxVelocity(direction);
        }

        public void Decelerate()
        {
            AccelerateToVelocity(Vector3.zero);
        }

        public void MoveRigidbody(Rigidbody rigidbody)
        {
            if (!rigidbody) return;
            rigidbody.velocity = Velocity;
        }

        public void MoveTransform(Transform transform)
        {
            transform.position += Velocity * Time.deltaTime;
        }

        public void SetMaxSpeed(float newSpeed)
        {
            MaxSpeed = newSpeed;
        }
        
        public static Vector3 Vector3Damp(Vector3 source, Vector3 target, float accelCoefficient, float deltaTime) // make it extension function.
        {
            return Vector3.Lerp(source, target, 1f - Mathf.Exp(-accelCoefficient * deltaTime));
        }

        public void AccelerateToRandomDirection()
        {
            AccelerateInDirection(Random.insideUnitSphere);
        }

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            UnityEngine.Debug.DrawRay(transform.position, Velocity, Color.blue);
        }
#endif
    }
}
