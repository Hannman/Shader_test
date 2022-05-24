using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToKill : MonoBehaviour
{
    [SerializeField] GameEvent _onDied;
    private bool _dead;

    void OnMouseDown()
    {
        if (!_dead)
            Die();
    }

    void Die()
    {
        GetComponent<Animator>().SetBool("Dead", true);
        _onDied?.Invoke();
        _dead = true;
    }


}
