using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Panel;

    public void GameStart()
    {
        Player.SetActive(true);
        Panel.SetActive(false);
    }
}
