using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerAuRespawn : MonoBehaviour
{
    public GameObject[] spawnLocation;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SpawnPosition = " + Global.SpawnPosition);
        other.transform.position = spawnLocation[Global.SpawnPosition].transform.position;
        other.transform.rotation = spawnLocation[Global.SpawnPosition].transform.rotation;
    }
}
