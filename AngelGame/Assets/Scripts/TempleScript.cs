using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempleScript : MonoBehaviour
{
    public GameObject Endscreen;
    public GameObject WinScreen;
    public GameObject Player;
    public GameObject SavedText;
    public GameObject LostText;

    Text AmountSaved;
    Text AmountLost;

    public int Sinners = 6;
    public int Saved = 0;
    public int Lost = 0;

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
            IncreaseSaved();
        }
    }

    public void ReduceSinner()
    {
        Sinners = Sinners - 1;
    }

    void IncreaseSaved()
    {
        Saved = Saved + 1;
    }

    public void IncreaseLost()
    {
        Lost = Lost + 1;
    }

    void Start()
    {
        AmountSaved = SavedText.GetComponent<Text>();
        AmountLost = LostText.GetComponent<Text>();
    }

    void Update()
    {
        
        if (Sinners == 0)
        {
            Player.SetActive(false);
            WinScreen.SetActive(true);
            AmountSaved.text = Saved.ToString();
            AmountLost.text = Lost.ToString();
        }
    }
}
