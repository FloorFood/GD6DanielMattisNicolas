using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public double countdownTime = 120;

    Text countdownText;
    double countdownInternal;
    bool countdownOver = false;

    public GameObject destruction;

    // Start is called before the first frame update
    void Start()
    {
        countdownText = GetComponent<Text>();
        countdownInternal = countdownTime;
    }

    void FixedUpdate()
    {
        if (countdownInternal > 0)
        {
            countdownInternal -= Time.deltaTime;

            if (countdownInternal < 0)
            {
                countdownInternal = 0;
            }

            countdownText.text = timelayout(countdownInternal);
        }
        else
        {
            if (!countdownOver)
            {
                countdownOver = true;
                Debug.Log("0");

                destruction.GetComponent<DestructionCount>().Rordon();
            }
        }
    }

    string timelayout(double time)
    {
        string timeText = "";

        int intTime = (int)time;
        int secondsTotal = intTime;

        timeText = string.Format("{0:00}", secondsTotal);

        return timeText;
    }
}
