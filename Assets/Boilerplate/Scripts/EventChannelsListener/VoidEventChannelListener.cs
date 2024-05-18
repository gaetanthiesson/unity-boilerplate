using UnityEngine;
using UnityEngine.Events;

public class VoidEventChannelListener : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO _eventChannel;
    [Space]
    [SerializeField] private UnityEvent _callback;

    private void OnEnable()
    {
        if(_eventChannel != null) _eventChannel.OnEventRaised += OnEventRaised;
    }

    private void OnDisable()
    {
        if(_eventChannel != null) _eventChannel.OnEventRaised -= OnEventRaised;
    }

    public void OnEventRaised()
    {
        _callback?.Invoke();
    }
}
