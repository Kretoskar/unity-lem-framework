using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LemFramework.Patterns
{
    public class DontDestroyOnLoad : Singleton<DontDestroyOnLoad>
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}