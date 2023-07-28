using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class ColliderOnClickAction : MonoBehaviour
    {
        protected Action OnClickAction;
        private BoxCollider2D _collider2D;

        protected abstract void Initialize();

        private void Start()
        {
            _collider2D = GetComponent<BoxCollider2D>();
            Initialize();
        }

        private void Update()
        {
            CheckForColliderClick();
        }

        public void CheckForColliderClick()
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(screenPoint, Vector2.zero);

                if (hit.collider == _collider2D)
                {
                    OnClickAction?.Invoke();
                }
            }
        }
    }
}
