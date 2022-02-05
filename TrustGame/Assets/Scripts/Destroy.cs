using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject ThisObject;
    public GameObject Explotion;
    public GameObject destruction;

    void Explode()
    {
        destruction.GetComponent<DestructionCount>().DestructionUpdate();
        Explotion.SetActive(true);
        ThisObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Explode();
        }
    }
}
