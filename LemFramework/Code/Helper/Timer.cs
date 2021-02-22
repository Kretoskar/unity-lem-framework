using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace LemFramework.Helper
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private float _duration = 0;
        [SerializeField] private UnityEvent _onTimerEnd = new UnityEvent();

        public Action OnTimerEnd;

        public void StartTimer(float duration) => StartCoroutine(CountTime(duration));

        public void StartTimer() => StartCoroutine(CountTime(_duration));

        private IEnumerator CountTime(float duration)
        {
            yield return new WaitForSeconds(duration);

            _onTimerEnd?.Invoke();
            OnTimerEnd?.Invoke();
        }
    }
}