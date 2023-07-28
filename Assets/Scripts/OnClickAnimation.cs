using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class OnClickAnimation : ColliderOnClickAction
{
    private Animator _animator;

    protected override void Initialize()
    {
        OnClickAction = AnimateAction;
        _animator = GetComponent<Animator>();
    }

    private void AnimateAction()
    {
        _animator.SetTrigger("action_trigger");
    }
}
