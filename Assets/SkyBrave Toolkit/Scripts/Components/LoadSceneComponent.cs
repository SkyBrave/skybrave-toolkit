using UnityEngine;
using UnityEngine.SceneManagement;

namespace SkyBrave_Toolkit.Scripts.Components
{
    public class LoadSceneComponent : MonoBehaviour
    {
        public void ReLoadCurrentUnityScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void LoadNextUnityScene()
        {
            var sceneIndexToLoad = Mathf.Clamp(SceneManager.GetActiveScene().buildIndex + 1, 0, SceneManager.sceneCountInBuildSettings - 1);
            SceneManager.LoadScene(sceneIndexToLoad);
        }
        
        public void LoadPreviousUnityScene()
        {
            var sceneIndexToLoad = Mathf.Clamp(SceneManager.GetActiveScene().buildIndex - 1, 0, SceneManager.sceneCountInBuildSettings - 1);
            SceneManager.LoadScene(sceneIndexToLoad);
        }
    }
}
