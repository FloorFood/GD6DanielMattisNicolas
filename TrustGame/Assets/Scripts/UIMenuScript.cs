using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("TutorialScene");
        AudioManager.instance.currentScene = "Game";
    }

    public void Quit()
    {
        Application.Quit();
    }
}
