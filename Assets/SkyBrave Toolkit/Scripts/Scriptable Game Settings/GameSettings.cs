using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Scriptable_Game_Settings
{
    [CreateAssetMenu(fileName = "Scriptable Game Settings", menuName = "Scriptable Game Settings/New Game Settings")]
    public class GameSettings : ScriptableObject
    {
        [Header("Post Processing Settings")] 
        public bool IsPostProcessingEnabled = true;
    
        [Header("Audio")]
        [Range(0f, 1f)] public float MasterVolumeRate = 1f;

        [Header("SFX Settings")] 
        public bool IsSFXEnabled = true;
        [Range(0f, 1f)] public float SFXVolumeRate = 0.2f;
        [Range(0f, 1f)] public float AmbienceVolume = 0.1f;
    
    
        [Header("Music Settings")] 
        public bool IsMusicEnabled = true;
        [Range(0f, 1f)] public float MusicVolumeRate = 0.5f;

        public void TogglePostProcessing()
        {
            IsPostProcessingEnabled = !IsPostProcessingEnabled;
        }
    
        public void ToggleSFX()
        {
            IsSFXEnabled = !IsSFXEnabled;
        }
    
        public void ToggleMusic()
        {
            IsMusicEnabled = !IsMusicEnabled;
        }

        public void SetMusicStatus(bool status)
        {
            IsMusicEnabled = status;
        }
    
        public void SetSFXStatus(bool status)
        {
            IsSFXEnabled = status;
        }
    
        public void ModifyMasterVolume(float modificationValue)
        {
            MasterVolumeRate = Mathf.Clamp(MasterVolumeRate + modificationValue, 0f, 1f);
        }
    
        public void ModifySFXVolume(float modificationValue)
        {
            SFXVolumeRate = Mathf.Clamp(SFXVolumeRate + modificationValue, 0f, 1f);
        }
    
        public void ModifyMusicVolume(float modificationValue)
        {
            MusicVolumeRate = Mathf.Clamp(MusicVolumeRate + modificationValue, 0f, 1f);
        }
    }
}