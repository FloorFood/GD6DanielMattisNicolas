using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleScript : MonoBehaviour
{
    public GameObject Endscreen;
    public GameObject WinScreen;
    public GameObject Player;

    public int Sinners = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Endscreen.GetComponent<Defeat>().ResetAlpha();
            Endscreen.SetActive(false);
        }
        if (collision.gameObject.tag == "Sinner")
        {
            //You save the sinner.
            Destroy(collision.gameObject);
            ReduceSinner();
        }
    }

    public void ReduceSinner()
    {
        Sinners = Sinners - 1;
    }
    void Update()
    {
        
        if (Sinners == 0)
        {
            Player.SetActive(false);
            WinScreen.SetActive(true);
        }
    }
}
