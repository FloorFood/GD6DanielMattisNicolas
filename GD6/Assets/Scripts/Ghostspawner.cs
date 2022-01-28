using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostspawner : MonoBehaviour
{
    public GameObject LeftGhost;
    public GameObject RightGhost;

    void Spawn()
    {
        int rando = Random.Range(0, 2);

        if (rando == 0)
        {
                LeftGhost.SetActive(true);
        }

        if (rando == 1)
        {
            RightGhost.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("down"))
        {
            Spawn();
        }
    }
}
