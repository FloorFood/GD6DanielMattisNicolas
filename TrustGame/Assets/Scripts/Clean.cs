using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    public GameObject ThisDirt;
    
    void clean()
    {
        // Play cleaning sound
        ThisDirt.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            clean();
        }
    }
}
