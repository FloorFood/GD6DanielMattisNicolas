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
    public GameObject video;
    public GameObject videoLoop;
    public GameObject restartLoose;
    public GameObject exitLoose;
    public GameObject videoWin;
    public GameObject restartWin;
    public GameObject exitWin;

    public float videoLenght = 7.8f;
    public float videolong = 7.37f;

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
            PlayWin();
            //thisObject.SetActive(false);
        }
        else
        {
            player.SetActive(false);
            failure.SetActive(true);
            
            countdown.SetActive(false);
            TotalDestruction.SetActive(false);
            ExplotionImage.SetActive(false);
            PlayLoose();
            //thisObject.SetActive(false);
        }
    }

    void PlayWin()
    {
        videoWin.SetActive(true);
        AudioManager.instance.currentScene = "NoLongerGame";
        StartCoroutine(Wait2(videolong));
    }

    IEnumerator Wait2(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        restartWin.SetActive(true);
        exitWin.SetActive(true);
    }

    void PlayLoose()
    {
        video.SetActive(true);
        AudioManager.instance.currentScene = "NoLongerGame";
        StartCoroutine(Wait(videoLenght));
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        videoLoop.SetActive(true);
        restartLoose.SetActive(true);
        exitLoose.SetActive(true);
    }
}
