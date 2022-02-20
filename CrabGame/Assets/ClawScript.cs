using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{

    bool LeftClick = false;
    //bool RightClick = false;
    private void OnTriggerStay2D(Collision2D collision2D)
    {
        if (LeftClick == true)
        {
            Debug.Log("HoldLeft");
            //attach collided object to this object
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftClick = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            LeftClick = false;
        }
    }
}
