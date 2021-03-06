using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    /// <summary>
    /// MonoBehaviour for listening to GameEvents, then transferring the information to UnityEvents
    /// </summary>
    /// 
    /// <remarks>
    /// Declaring new subclasses for the VariableGameEvents and UnityEvents
    /// is required because Unity will not display generic fields in the inspector,
    /// only classes that inherit from the generic
    ///
    /// The parameters G needs to be declared inside an individual script
    /// so that it can create scriptable objects, in the same way that
    /// individual VariableEventListeners need to be declared inside individual
    /// scripts so that they can be attached to gameObjects as components
    /// 
    /// The Parameter U can be declared anywhere but also need their own declarations
    /// so that they can be serialized in the inspector
    /// </remarks>
    ///
    /// <typeparam name="T">Base type of following parameters</typeparam>
    /// <typeparam name="G">Subclass of VariableGameEvent with type T</typeparam>
    /// <typeparam name="U">Subclass of UnityEvent with type T</typeparam>

    [System.Serializable]
    public abstract class VariableEventListener<T, G, U> : MonoBehaviour where G : VariableGameEvent<T, G, U> where U : UnityEvent<T>
    {
        [Tooltip("Event to register with.")] [SerializeField]
        public G Event;

        [Tooltip("Response to invoke when Event is raised.")] [SerializeField]
        public U Response;

        void OnEnable()
        {
            Event.RegisterListener(this);
        }

        void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T value)
        {
            Response.Invoke(value);
        }
    }
}