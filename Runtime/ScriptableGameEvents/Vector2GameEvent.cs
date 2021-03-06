using System;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/Vector2")] [Serializable]
    public class Vector2GameEvent : VariableGameEvent<Vector2, Vector2GameEvent, Vector2UnityEvent>{}
    
    [Serializable]
    public class Vector2UnityEvent : UnityEvent<Vector2> { }
}