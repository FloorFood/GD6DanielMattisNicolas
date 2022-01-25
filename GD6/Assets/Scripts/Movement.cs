using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject LeftSlap;
    public GameObject RightSlap;
    public GameObject Hand;
    public bool Slapping = false;
    public float Cooldown = 0.25f;

    void SlapLeft()
    {
        Hand.SetActive(false);
        LeftSlap.SetActive(true);
        Slapping = true;
        Debug.Log("0");
        StartCoroutine(Wait());
    }

    void SlapLeftDone()
    {
        Debug.Log("1");
        Slapping = false;
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
        Debug.Log("0");
        StartCoroutine(Waiting());
    }

    void SlapRightDone()
    {
        Debug.Log("1");
        Slapping = false;
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
            Debug.Log("Left");
        }

        if (Input.GetKeyDown("right"))
        {
            if (Slapping == false)
            SlapRight();
            Debug.Log("Right");
        }
    }
}
