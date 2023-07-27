using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ChangeScene()
    {
        int currentSceneId = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneId == 0 ? 1: currentSceneId);
    }
}
