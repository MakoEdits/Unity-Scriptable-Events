using System;
using UnityEngine;
using UnityEngine.Events;

namespace Mako.ScriptableEvents
{
    [CreateAssetMenu(menuName = "GameEvents/Float")] [Serializable]
    public class FloatGameEvent : VariableGameEvent<float, FloatGameEvent, FloatUnityEvent>{}
    
    [Serializable]
    public class FloatUnityEvent : UnityEvent<float> { }
}