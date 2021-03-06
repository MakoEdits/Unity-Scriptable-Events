using System;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/Bool")] [Serializable]
    public class BoolGameEvent : VariableGameEvent<bool, BoolGameEvent, BoolUnityEvent>{}
    
    [Serializable]
    public class BoolUnityEvent : UnityEvent<bool> { }
}