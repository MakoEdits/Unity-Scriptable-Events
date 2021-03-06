using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    public class GenericEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GenericGameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        void OnEnable()
        {
            Event.RegisterListener(this);
        }

        void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}