using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructionCount : MonoBehaviour
{
    public Text destructionText;
    private int DestroyedObjects = 0;
    private int CleanedDirts = 0;

    public GameObject victory;
    public GameObject failure;
    public GameObject player;
    public GameObject countdown;
    public GameObject thisObject;
    public GameObject ExplotionImage;
    
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
        DestroyedObjects = DestroyedObjects + 1;
    }

    public void CleaningUpdate()
    {
        CleanedDirts = CleanedDirts + 1;
    }

    public void Rordon()
    {
        if (DestroyedObjects == 0 && CleanedDirts == 9)
        {
            player.SetActive(false);
            victory.SetActive(true);
            countdown.SetActive(false);
            ExplotionImage.SetActive(false);
            thisObject.SetActive(false);
        }
        else
        {
            player.SetActive(false);
            failure.SetActive(true);
            countdown.SetActive(false);
            ExplotionImage.SetActive(false);
            thisObject.SetActive(false);
        }
    }
}
