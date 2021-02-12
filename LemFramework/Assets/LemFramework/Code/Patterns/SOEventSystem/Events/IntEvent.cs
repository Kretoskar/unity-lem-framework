﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LemFramework.Patterns.SOEventSystem
{
    [CreateAssetMenu(fileName = "New Int Event", menuName = "Game Events/Int Event")]
    public class IntEvent : BaseGameEvent<int> { }
}