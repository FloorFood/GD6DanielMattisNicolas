using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGhost : MonoBehaviour
{
    public float alive = 0.5f;

    IEnumerator TouchRemote()
    {
        yield return new WaitForSeconds(alive);
        Monster();
    }

    void Monster()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TouchRemote());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
