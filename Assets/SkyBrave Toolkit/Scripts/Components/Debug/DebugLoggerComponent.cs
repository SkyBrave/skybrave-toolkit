using UnityEngine;
using Object = UnityEngine.Object;

namespace SkyBrave_Toolkit.Scripts.Components
{
    public class DebugLoggerComponent : MonoBehaviour
    {
        [Header("Logic")]
        [SerializeField] private bool _showLogs;
        [SerializeField] private string _prefix;
        [SerializeField] private Color _prefixColor;

        private string _hexColor;
        
        private void OnValidate()
        {
            _hexColor = "#" + ColorUtility.ToHtmlStringRGBA(_prefixColor);
        }
        
        public void LogMessageWithSender(object message, Object sender)
        {
            if (!_showLogs) return;
            Debug.Log($"<color={_hexColor}>{_prefix}:</color> {message}", sender);
        }
        
        public void LogMessage(string message)
        {
            if (!_showLogs) return;
            Debug.Log($"<color={_hexColor}>{_prefix}:</color> {message}");
        }
    }
}
