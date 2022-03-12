using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelGaze : MonoBehaviour
{
    public GameObject[] objectPool;
    public GameObject Eye;
    private int currentIndex = 0;

    float elapsedTime = 0f;
    public float repeatTime = 1f;

    public void NewRandomDirection()
    {
        Eye.GetComponent<IrisController>().EmptyLook();
        int newIndex = Random.Range(0, objectPool.Length);
        objectPool[currentIndex].SetActive(false);
        currentIndex = newIndex;
        objectPool[currentIndex].SetActive(true);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= repeatTime)
        {
            NewRandomDirection();

            elapsedTime -= repeatTime;
        }
    }
}
