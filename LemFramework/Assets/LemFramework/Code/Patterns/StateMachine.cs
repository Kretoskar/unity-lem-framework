using System;
using System.Collections;
using System.Collections.Generic;
using LemFramework.Patterns;
using UnityEngine;
using Random = UnityEngine.Random;

public class StateMachine : MonoBehaviour
{
    [Header("READONLY FIELDS")]
    [SerializeField]
    private string _state = "";

    [SerializeField]
    protected List<string> _asynchronousStatesNames = null;
    
    protected List<IAsynchronousState> _asynchronousStates;
    
    protected IState _currentState;
    protected IState _startState;
    
    protected int _ratioTotal;
    protected Dictionary<IState, Vector2> _statesWIthPriorities;

    protected virtual void SetStartState() { }
    
    protected virtual void SetCurrentStateToStartState()
    {
        ChangeState(_startState);
    }
    
    protected virtual void ChangeState(IState newState)
    {
        if(_currentState != null)
            if(!_currentState.Finished || _currentState == newState)
                return;
            
        _currentState?.Exit();
        _currentState = newState;
        _state = newState.GetType().Name;
        newState.Enter(this);
    }

    protected virtual void StartAsynchronousState(IAsynchronousState asyncState)
    {
        if(_asynchronousStates == null) _asynchronousStates = new List<IAsynchronousState>();
        
        _asynchronousStates.Add(asyncState);
        _asynchronousStatesNames.Add(asyncState.GetType().Name);
        
        asyncState.Enter();
    }
    
    protected virtual void SelectStateRandomlyWithPriority()
    {
        int choosenStateIndex = Random.Range(0, _ratioTotal);

        foreach (var state in _statesWIthPriorities)
        {
            if(choosenStateIndex >= state.Value.x && choosenStateIndex <= state.Value.y)
                ChangeState(state.Key);
        }
    }
}