using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components
{
    public class SpawnObjectComponent : MonoBehaviour
    {
        [Header("Parameters")]
        public GameObject ObjectToSpawn;
        public Vector3 SpawnPos;
        public Vector3 SpawnRot;

        public void Spawn()
        {
            var spawnedObject = Instantiate(ObjectToSpawn, SpawnPos, Quaternion.Euler(SpawnRot));
        }
    }
}
