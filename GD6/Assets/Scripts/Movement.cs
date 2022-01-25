using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject LeftSlap;
    public GameObject RightSlap;
    public GameObject Hand;

    void SlapLeft()
    {
        Hand.SetActive(false);
        LeftSlap.SetActive(true);
        Debug.Log("0");
        StartCoroutine(Wait(1));
    }

    void SlapLeftDone()
    {
        Debug.Log("1");
        Hand.SetActive(true);
        LeftSlap.SetActive(false);
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SlapLeftDone();
    }

    void SlapRight()
    {
        Hand.SetActive(false);
        RightSlap.SetActive(true);
        Debug.Log("0");
        StartCoroutine(Waiting(1));
    }

    void SlapRightDone()
    {
        Debug.Log("1");
        Hand.SetActive(true);
        RightSlap.SetActive(false);
    }

    IEnumerator Waiting(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SlapRightDone();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            SlapLeft();
            Debug.Log("Left");
        }

        if (Input.GetKeyDown("right"))
        {
            SlapRight();
            Debug.Log("Right");
        }
    }
}
