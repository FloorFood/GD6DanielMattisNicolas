using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour
{
    float alpha = Mathf.Clamp(0, 0, 1);

    public GameObject RestartButton;
    public GameObject ExitButton;
    public GameObject Player;
    public GameObject Background;
    void Awake()
    {
        Color tmp = Background.GetComponent<SpriteRenderer>().color;
        tmp.a = alpha;
        Background.GetComponent<SpriteRenderer>().color = tmp;
    }

    void FixedUpdate()
    {
            alpha = alpha + 0.01f;
        Color tmp = Background.GetComponent<SpriteRenderer>().color;
        tmp.a = alpha;
        Background.GetComponent<SpriteRenderer>().color = tmp;

        if (alpha >= 0.99f)
        {
            Player.SetActive(false);
            RestartButton.SetActive(true);
            ExitButton.SetActive(true);
        }
    }

    public void ResetAlpha()
    {
        alpha = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
