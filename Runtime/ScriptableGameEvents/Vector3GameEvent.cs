using System;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/Vector3")] [Serializable]
    public class Vector3GameEvent : VariableGameEvent<Vector3, Vector3GameEvent, Vector3UnityEvent>{}
    
    [Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { }
}