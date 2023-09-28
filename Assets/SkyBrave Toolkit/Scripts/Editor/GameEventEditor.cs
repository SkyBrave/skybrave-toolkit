using SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Scriptable_Game_Events;
using UnityEditor;
using UnityEngine;

namespace SkyBrave_Toolkit.SkyBrave_Toolkit.Scripts.Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(GameEvent), editorForChildClasses: true)]
    public class EventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent e = target as GameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
#endif
}