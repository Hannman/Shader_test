using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListenerWithDelay : GameEventListener
{
    [SerializeField] float _delay = 1f;
    [SerializeField] UnityEvent _delayedUnityEvent;

    public override void RaiseEvent() 
    {
        StartCoroutine(RunDelayedEvent());
    }

    private IEnumerator RunDelayedEvent() 
    {
        yield return new WaitForSeconds(_delay);
        _delayedUnityEvent.Invoke();
    }
}
