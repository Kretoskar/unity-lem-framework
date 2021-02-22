using System;
using Game.Audio;
using UnityEngine.Events;

namespace LemFramework.Patterns.SOEventSystem
{
    [Serializable]
    public class UnitySoundEvent : UnityEvent<SoundData>
    {
        
    }
}