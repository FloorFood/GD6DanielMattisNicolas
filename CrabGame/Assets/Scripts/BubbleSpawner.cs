using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BubbleSpawner : MonoBehaviour
{
    private int randomNumber;
    private float countdown;
    public GameObject bubblePrefab;

    void Start()
    {
        randomNumber = Random.Range(2, 13);
        countdown = (float)randomNumber;
    }

    void Update()
    {
        //Debug.Log("Random number is: " + randomNumber);
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
            //Debug.Log("Countdown left: " + countdown);
        }
        else if (countdown <= 0)
        {
            Instantiate(bubblePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), transform.rotation);
            AudioManager.instance.shouldRandomizePitch = true;
            //AudioManager.instance.PlaySound("Bubbles");
            randomNumber = Random.Range(8, 21);
            countdown = (float)randomNumber;
        }
    }
}
