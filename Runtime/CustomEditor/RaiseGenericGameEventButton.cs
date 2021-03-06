using UnityEngine;
using UnityEditor;

namespace Mako.ScriptableEvents
{
    [CustomEditor(typeof(GenericGameEvent), editorForChildClasses: true)]
    public class RaiseGenericGameEventButton : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GenericGameEvent e = target as GenericGameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
}