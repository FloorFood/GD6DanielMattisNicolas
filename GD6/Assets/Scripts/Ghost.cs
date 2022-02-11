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

    void Move()
    {
        NextGhost.SetActive(true);
        ThisGhost.SetActive(false);
    }

    void OnEnable()
    {
        StartCoroutine(Travel());

    }
}
