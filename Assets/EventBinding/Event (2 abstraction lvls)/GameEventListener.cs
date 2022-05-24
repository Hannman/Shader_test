using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] GameEvent _gameEvent;
    [SerializeField] UnityEvent _unityEvent;

    void Awake() => _gameEvent.Register(this);
    private void OnDestroy() => _gameEvent.Deregister(this);
    public virtual void RaiseEvent() => _unityEvent.Invoke();
}
