using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClawScript : MonoBehaviour
{
    public GameObject Arm;
    //public GameObject OtherArm;
    private Collider2D ArmCollider;
    //private Collider2D OtherArmCollider;
    bool RightClick = false;
    bool HasLetGo = false;
    int Leegos = 0;

    void OnTriggerStay2D(Collider2D collision2D)
    {
        if (RightClick && Leegos == 1)
        {
            if (collision2D.tag == "leego")
            {
                ArmCollider.enabled = false;
                //OtherArmCollider.enabled = false;
                collision2D.attachedRigidbody.GetComponent<BoxCollider2D>().isTrigger = true;
                collision2D.attachedRigidbody.freezeRotation = true;
                collision2D.attachedRigidbody.transform.position = gameObject.transform.position;
            }
        }
            
        if (RightClick && collision2D.tag == "button")
        {
            Screenshot();
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
        if (Input.GetMouseButtonDown(1))
        {
            HasLetGo = false;
            RightClick = true;
            AudioManager.instance.PlaySound("CrabClawSnap");
        }

        if (Input.GetMouseButtonUp(1))
        {
            HasLetGo = true;
            RightClick = false;
            ArmCollider.enabled = true;
            //OtherArmCollider.enabled = true;
        }
    }
    public void Screenshot()
    {
        //possibly animate the button going down.
        //play camera beep sound and maybe animate a flash.
        AudioManager.instance.PlaySound("CameraReady");
        RightClick = false;
        StartCoroutine(Ending());
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(5);
        AudioManager.instance.PlaySound("CameraSnap");
        Debug.Log("Buttonpressed");
        TakeScreenshot();

        yield return new WaitForSeconds(2);
        Debug.Log("end");
        Application.Quit();
    }

    public void TakeScreenshot()
    {
        ScreenCapture.CaptureScreenshot("BuiltByCrab.png");
    }
}
