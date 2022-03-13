using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrisController : MonoBehaviour
{
    public GameObject[] look1;
    
    void Update()
    {
        if (look1.Length == 0)
        {
            look1 = GameObject.FindGameObjectsWithTag("Gaze");
        }
            
        foreach (GameObject gaze in look1)
        {
            Vector3 eyePosition = gaze.transform.position;

            Vector2 direction = eyePosition - transform.position;
            float angle = Vector2.SignedAngle(Vector2.right, direction);
            transform.eulerAngles = new Vector3(0, 0, angle);
        }
    }

    public void EmptyLook()
    {
        System.Array.Clear(look1, 0, look1.Length);
        look1 = GameObject.FindGameObjectsWithTag("Gaze");
    }
}
