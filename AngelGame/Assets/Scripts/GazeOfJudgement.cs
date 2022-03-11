using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeOfJudgement : MonoBehaviour
{
    public GameObject Endscreen;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sinner")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Endscreen.SetActive(true);
        }
    }
}
