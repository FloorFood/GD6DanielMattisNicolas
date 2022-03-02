using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BubbleSpawner : MonoBehaviour
{
    private int randomNumber;
    private int countdown;
    public GameObject bubblePrefab;

    void Start()
    {
        randomNumber = Random.Range(2, 16);
        countdown = randomNumber * 60;
    }

    void Update()
    {
        //Debug.Log("Random number is: " + randomNumber);
        if (countdown > 0)
        {
            countdown--;
            //Debug.Log("Countdown left: " + countdown);
        }
        else if (countdown <= 0)
        {
            Instantiate(bubblePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), transform.rotation);
            AudioManager.instance.shouldRandomizePitch = true;
            AudioManager.instance.PlaySound("Bubbles");
            randomNumber = Random.Range(8, 26);
            countdown = randomNumber * 60;
        }
    }
}
