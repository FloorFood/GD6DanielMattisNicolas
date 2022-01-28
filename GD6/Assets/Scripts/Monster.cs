using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    public GameObject Face;

    public int RemotePresses = 1;

    public float die = 2f;

    public void PressRemote()
    {
        RemotePresses++;
    }

    public void CheckRemotePresses()
    {
        if (RemotePresses == 2)
        {
            sprite1.SetActive(true);
        }

        if (RemotePresses == 3)
        {
            sprite1.SetActive(false);
            sprite2.SetActive(true);
        }

        if (RemotePresses == 4)
        {
            sprite2.SetActive(false);
            sprite3.SetActive(true);
        }

        if (RemotePresses == 5)
        {
            sprite3.SetActive(false);
            sprite4.SetActive(true);
        }

        if (RemotePresses == 6)
        {
            sprite4.SetActive(false);
            Face.SetActive(true);
            StartCoroutine(Death());
        }

        IEnumerator Death()
        {
            yield return new WaitForSeconds(die);
            Debug.Log("You died");
            Quit();
        }

        void Quit()
        {
            Application.Quit();
        }
    }
}
