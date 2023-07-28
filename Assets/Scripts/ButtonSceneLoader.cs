using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSceneLoader : MonoBehaviour
{
    private Button _button;
    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeScene);
    }

    public void ChangeScene()
    {
        int currentSceneId = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneId == 0 ? 1 : 0);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }
}
