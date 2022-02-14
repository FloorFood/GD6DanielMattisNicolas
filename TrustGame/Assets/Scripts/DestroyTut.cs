using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTut : MonoBehaviour
{
    public GameObject ThisObject;
    public GameObject Explotion;

    void explode()
    {
        AudioManager.instance.shouldRandomizePitch = true;
        AudioManager.instance.PlaySound("Boom");
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
