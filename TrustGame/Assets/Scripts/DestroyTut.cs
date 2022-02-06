using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTut : MonoBehaviour
{
    public GameObject ThisObject;
    public GameObject Explotion;

    void explode()
    {
        Explotion.SetActive(true);
        ThisObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            explode();
        }
    }
}
