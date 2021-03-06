using System;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/String")] [Serializable]
    public class StringGameEvent : VariableGameEvent<string, StringGameEvent, StringUnityEvent>{}
    
    [Serializable]
    public class StringUnityEvent : UnityEvent<string> { }
}