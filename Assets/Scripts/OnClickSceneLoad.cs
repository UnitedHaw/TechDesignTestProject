using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class OnClickSceneLoad : ColliderOnClickAction
    {
        [SerializeField] private Button _sceneLoaderButton;

        protected override void Initialize()
        {
            OnClickAction = InvokeSceneLoaderButton;
        }

        private void InvokeSceneLoaderButton()
        {
            _sceneLoaderButton.onClick?.Invoke();
        }
    }
}
