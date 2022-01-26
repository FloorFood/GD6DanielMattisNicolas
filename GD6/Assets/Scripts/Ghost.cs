using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject ThisGhost;
    public GameObject NextGhost;
    public float advance = 0.5f;

    IEnumerator Travel()
    {
        yield return new WaitForSeconds(advance);
        Move();
    }

    private void Move()
    {
        NextGhost.SetActive(true);
        ThisGhost.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(Travel());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
