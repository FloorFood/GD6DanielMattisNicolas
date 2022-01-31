using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject LeftSlap;
    public GameObject RightSlap;
    public GameObject Hand;
    public GameObject LeftGhost3;
    public GameObject RightGhost3;
    public bool Slapping = false;
    public float Cooldown = 0.4f;
    public bool DestroyGhostLeft = false;
    public bool DestroyGhostRight = false;

    void SlapLeft()
    {
        Hand.SetActive(false);
        LeftSlap.SetActive(true);
        Slapping = true;
        FindObjectOfType<AudioManager>().PlaySound("Slap");
        DestroyGhostLeft = true;
        StartCoroutine(Wait());
    }

    void SlapLeftDone()
    {
        Slapping = false;
        DestroyGhostLeft = false;
        Hand.SetActive(true);
        LeftSlap.SetActive(false);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Cooldown);
        SlapLeftDone();
    }

    void SlapRight()
    {
        Hand.SetActive(false);
        RightSlap.SetActive(true);
        Slapping = true;
        FindObjectOfType<AudioManager>().PlaySound("Slap");
        DestroyGhostRight = true;
        StartCoroutine(Waiting());
    }

    void SlapRightDone()
    {
        Slapping = false;
        DestroyGhostRight = false;
        Hand.SetActive(true);
        RightSlap.SetActive(false);
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(Cooldown);
        SlapRightDone();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            if (Slapping == false)
            SlapLeft();
        }

        if (Input.GetKeyDown("right"))
        {
            if (Slapping == false)
            SlapRight();
        }

        if (DestroyGhostLeft == true)
        {
            LeftGhost3.GetComponent<LastGhostLeft>().DestroyLeft();
        }

        if (DestroyGhostRight == true)
        {
            RightGhost3.GetComponent<LastGhostLeft>().DestroyRight();
        }
    }
}
