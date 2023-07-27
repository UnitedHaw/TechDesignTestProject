using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class OnClickAnimation : MonoBehaviour
{
    private Animator _animator;
    private BoxCollider2D _collider2d;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _collider2d = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        MouseClick();
    }

    private void MouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(screenPoint, Vector2.zero);

            if (hit.collider == _collider2d)
            {
                AnimateAction();
            }
        }
    }

    private void AnimateAction()
    {
        _animator.SetTrigger("action_trigger");
    }
}
