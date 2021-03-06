using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    /// <summary>
    /// ScriptableObject to be raised by other scripts and listened to by VariableEventListeners
    /// </summary>
    /// <remarks>
    /// Individual subclasses need to inherit from this class to create their own individual ScriptableObjects
    /// </remarks>
    /// <typeparam name="T">Base type of following parameters</typeparam>
    /// <typeparam name="G">Subclass of VariableGameEvent with type T</typeparam>
    /// <typeparam name="U">Subclass of UnityEvent with type T</typeparam>

    [System.Serializable]
    public abstract class VariableGameEvent<T, G, U> : ScriptableObject where G : VariableGameEvent<T, G, U> where U : UnityEvent<T>
    {
        readonly List<VariableEventListener<T, G, U>> eventListeners = new List<VariableEventListener<T, G, U>>();

        public void Raise(T value)
        {
            for(var i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised(value);
        }

        public void RegisterListener(VariableEventListener<T, G, U> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(VariableEventListener<T, G, U> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}