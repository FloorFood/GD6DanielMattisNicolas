using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructionCount : MonoBehaviour
{
    public Text destructionText;
    private int DestroyedObjects = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        destructionText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        destructionText.text = "" + DestroyedObjects;
    }

    public void DestructionUpdate()
    {
        Debug.Log("+1");
        DestroyedObjects = DestroyedObjects + 1;
    }
}
