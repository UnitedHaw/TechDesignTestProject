using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class OnClickAttack : ColliderOnClickAction
{
    private Animator _animator;
    [SerializeField] private UnityEvent _onClickEvent;

    protected override void Initialize()
    {
        OnClickAction = AttackAction;
        _animator = GetComponent<Animator>();
    }

    private void AttackAction()
    {
        _animator.SetTrigger("action_trigger");
        _onClickEvent?.Invoke();
    }
}
