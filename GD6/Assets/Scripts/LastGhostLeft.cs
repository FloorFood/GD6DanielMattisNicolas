﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGhostLeft : MonoBehaviour
{
    public float alive = 0.5f;
    public GameObject thisGhost;
    public GameObject DestroyedGhost;
    public GameObject MonsterController;

    IEnumerator TouchRemote()
    {
        yield return new WaitForSeconds(alive);
        Debug.Log("Touches remote");
        monster();
    }

    void monster()
    {
        MonsterController.GetComponent<Monster>().PressRemote();
        MonsterController.GetComponent<Monster>().CheckRemotePresses();
    }

    public void DestroyLeft()
    {
        DestroyedGhost.SetActive(true);
        Debug.Log("Ghost dies left):");
        thisGhost.SetActive(false);
    }

    public void DestroyRight()
    {
        DestroyedGhost.SetActive(true);
        Debug.Log("Ghost dies right):");
        thisGhost.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TouchRemote());
    }
}
