using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{
    public GameObject Arm;
    //public GameObject OtherArm;
    private Collider2D ArmCollider;
    //private Collider2D OtherArmCollider;
    bool LeftClick = false;
    bool HasLetGo = false;
    int Leegos = 0;

    void OnTriggerStay2D(Collider2D collision2D)
    {
        if (LeftClick && Leegos == 1)
        {
            if (collision2D.tag == "leego")
            {
                ArmCollider.enabled = false;
                //OtherArmCollider.enabled = false;
                collision2D.attachedRigidbody.GetComponent<BoxCollider2D>().isTrigger = true;
                collision2D.attachedRigidbody.freezeRotation = true;
                collision2D.attachedRigidbody.transform.position = gameObject.transform.position;
            }
            else 
            if (collision2D.tag == "button")
            {
                Screenshot();
            }
        }
        else
        {
            if (collision2D.tag == "leego")
            {
                collision2D.attachedRigidbody.freezeRotation = false;
                collision2D.attachedRigidbody.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }

        if (HasLetGo)
        {
            collision2D.attachedRigidbody.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "leego")
        {
            Leegos = Leegos + 1;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "leego")
        {
            Leegos = Leegos - 1;
        }
    }

    private void Start()
    {
        ArmCollider = Arm.GetComponent<Collider2D>();
        //OtherArmCollider = OtherArm.GetComponent<Collider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HasLetGo = false;
            LeftClick = true;
            //pinch sound
        }

        if (Input.GetMouseButtonUp(0))
        {
            HasLetGo = true;
            LeftClick = false;
            ArmCollider.enabled = true;
            //OtherArmCollider.enabled = true;
        }
    }

    public void Screenshot()
    {
        //possibly animate the button going down.
        //play camera sound and play a flash.
        ScreenCapture.CaptureScreenshot("BuiltByCrab");
        StartCoroutine(Ending());
        Application.Quit();
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(5);
    }
}
