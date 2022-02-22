using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{
    public GameObject Arm;
    private Collider2D ArmCollider;
    bool LeftClick = false;
    //bool RightClick = false;
    void OnTriggerStay2D(Collider2D collision2D)
    {
        if (LeftClick == true)
        {
            if (collision2D.tag == "leego")
            {
                Debug.Log("HoldLeft");
                ArmCollider.enabled = false;
                collision2D.attachedRigidbody.transform.position = gameObject.transform.position;
            }
        }
        else
        {
            ArmCollider.enabled = true;
        }
    }

    private void Start()
    {
        ArmCollider = Arm.GetComponent<Collider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftClick = true;
            //pinch sound
        }

        if (Input.GetMouseButtonUp(0))
        {
            LeftClick = false;
        }
    }
}
