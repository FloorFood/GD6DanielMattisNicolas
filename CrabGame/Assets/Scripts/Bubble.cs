using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    private float deathCountdown = 6.0f; //Does this one need an explonation?
    private float speed = 2.2f; //How fast the bubble goes up
    private float frequency = 7.0f; //How fast the bubble swings
    private float magnitude = 0.2f; //How much the bubble swings

    private Vector3 axis;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        axis = transform.right;
    }

    void Update()
    {
        pos += transform.up * Time.deltaTime * speed;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;

        deathCountdown -= Time.deltaTime;
        if (deathCountdown <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
