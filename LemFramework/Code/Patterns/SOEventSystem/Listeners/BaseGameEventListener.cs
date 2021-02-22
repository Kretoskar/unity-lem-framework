using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LemFramework.Patterns.SOEventSystem
{
    /// <typeparam name="T">Type</typeparam>
    /// <typeparam name="E">Event</typeparam>
    /// <typeparam name="UER">Unity Event Response</typeparam>
    public abstract class BaseGameEventListener<T, E, UER> : MonoBehaviour, 
        IGameEventListener<T> where E : BaseGameEvent<T> where UER : UnityEvent<T>
    {
        [SerializeField] private E _gameEvent = null;
        [SerializeField] private UER _unityEventResponse = null;
        
        public E GameEvent
        {
            get => _gameEvent;
            set => _gameEvent = value;
        }

        private void OnEnable()
        {
            if(_gameEvent == null) return;

            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if(_gameEvent == null) return;

            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            _unityEventResponse?.Invoke(item);
        }
    }
}
