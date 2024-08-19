using System;
using UnityEngine;

public class GenericVariableSO<T> : ScriptableObject
{
    public Action OnValueChanged;

    [SerializeField] private T _value;


    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke();
        }
    }
}