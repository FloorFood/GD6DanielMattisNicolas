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
    public GameObject TotalDestruction;
    
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
        if (DestroyedObjects == 36)
        {
            TotalDestruction.SetActive(true);
        }
    }

    public void CleaningUpdate()
    {
        CleanedDirts = CleanedDirts + 1;
    }

    public void Rordon()
    {
        if (DestroyedObjects == 0 && CleanedDirts == 22)
        {
            player.SetActive(false);
            victory.SetActive(true);
            countdown.SetActive(false);
            TotalDestruction.SetActive(false);
            ExplotionImage.SetActive(false);
            thisObject.SetActive(false);
        }
        else
        {
            player.SetActive(false);
            failure.SetActive(true);
            countdown.SetActive(false);
            TotalDestruction.SetActive(false);
            ExplotionImage.SetActive(false);
            thisObject.SetActive(false);
        }
    }
}
