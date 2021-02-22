using System.Collections;
using System.Collections.Generic;
using Game.Audio;
using UnityEngine;

namespace LemFramework.Patterns.SOEventSystem
{
    [CreateAssetMenu(fileName = "New Sound Event", menuName = "Game Events/Custom types/Sound Event")]
    public class SoundEvent : BaseGameEvent<SoundData>
    {
    }
}