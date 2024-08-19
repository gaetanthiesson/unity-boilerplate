using UnityEngine;

public class GenericConstantSO<T> : ScriptableObject
{
    [SerializeField] private T _value;

    public T Value
    {
        get => _value;
    }
}