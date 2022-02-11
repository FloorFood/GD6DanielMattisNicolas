using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    public GameObject ThisDirt;
    public GameObject destruction;
    
    void clean()
    {
        // Play cleaning sound
        destruction.GetComponent<DestructionCount>().CleaningUpdate();
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
