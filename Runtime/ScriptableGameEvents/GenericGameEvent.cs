using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/Generic")]
    public class GenericGameEvent : ScriptableObject
    {
        GenericGameEvent(){}
        readonly List<GenericEventListener> eventListeners = new List<GenericEventListener>();

        public void Raise()
        {
            for(var i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(GenericEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GenericEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}