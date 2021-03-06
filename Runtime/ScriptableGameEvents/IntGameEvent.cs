using System;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/Int")] [Serializable]
    public class IntGameEvent : VariableGameEvent<int, IntGameEvent, IntUnityEvent>{}
    
    [Serializable]
    public class IntUnityEvent : UnityEvent<int> { }
}