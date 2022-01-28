using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostspawner : MonoBehaviour
{
    public GameObject LeftGhost;
    public GameObject RightGhost;

    public float SpawnInterval = 3;
    public float Spawntime = 0;

    public float TimeIncrease = 10;
    public float ToIncrease = 0;

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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("down"))
        {
            Spawn();
        }

        Spawntime += Time.deltaTime;

        if(SpawnInterval > 0.5f)
        {
            ToIncrease += Time.deltaTime;
        }

        if(Spawntime >= SpawnInterval)
        {
            Spawn();
            Spawntime = 0;
        }

        if(ToIncrease >= TimeIncrease)
        {
            {
                SpawnInterval -= 0.25f;
                ToIncrease = 0;
            }
        }
    }
}
