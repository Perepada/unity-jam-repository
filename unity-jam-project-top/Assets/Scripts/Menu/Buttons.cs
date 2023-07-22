using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void LoadScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void ActivateWindow(GameObject window)
    {
        window.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
