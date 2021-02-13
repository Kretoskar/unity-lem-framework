using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LemFramework.Patterns.SOEventSystem
{
    [CreateAssetMenu(fileName = "New void event", menuName = "Game Events/Void Event")]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}