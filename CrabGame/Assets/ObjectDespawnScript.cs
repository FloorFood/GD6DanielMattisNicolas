using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDespawnScript : MonoBehaviour
{
    public GameObject Spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Spawner.GetComponent<SpawnLeego>().LeegoNo();
    }
}
