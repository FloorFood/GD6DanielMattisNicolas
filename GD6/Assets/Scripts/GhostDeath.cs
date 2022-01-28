using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDeath : MonoBehaviour
{
    public GameObject ThisGhost;
    public float advance = 0.5f;

    IEnumerator Travel()
    {
        yield return new WaitForSeconds(advance);
        Move();
    }

    private void Move()
    {
        ThisGhost.SetActive(false);
    }

    private void OnEnable()
    {
        StartCoroutine(Travel());

    }
}
