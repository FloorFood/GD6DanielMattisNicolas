using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeego : MonoBehaviour
{
    public GameObject[] theLeegos;

    [Space(3)]
    public float waitingForNextSpawn = 7;
    public float theCountdown = 7;

    [Header("X Spawn Range")]
    public float xMin = -21f;
    public float xMax = -12f;

    [Header("Y Spawn Range")]
    public float yMin = 8.84f;
    public float yMax =9f;


    void Start()
    {
    }

    public void Update()
    {
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnLeegos();
            theCountdown = waitingForNextSpawn;
        }
    }


    void SpawnLeegos()
    {
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        GameObject leegoPrefab = theLeegos[Random.Range(0, theLeegos.Length)];
        Instantiate(leegoPrefab, pos, transform.rotation); 
    }
}
