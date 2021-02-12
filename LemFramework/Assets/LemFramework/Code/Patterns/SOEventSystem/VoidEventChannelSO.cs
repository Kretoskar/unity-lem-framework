﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/Void Event Channel")]
public class VoidEventChannelSO : ScriptableObject
{
    public Action OnEventRaised;

    public void RaiseEvent() => OnEventRaised?.Invoke();
}
