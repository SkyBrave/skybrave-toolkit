using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Components.Input
{
    public class CursorComponent : MonoBehaviour
    {
        public void ChangeVisibilityOfCursor(bool state)
        {
            Cursor.visible = state;
        }
        
        public void LockCursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        public void FreeCursorLockState()
        {
            Cursor.lockState = CursorLockMode.None;
        }

        public void ConfineCursorLockState()
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
