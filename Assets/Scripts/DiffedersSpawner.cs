using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffedersSpawner : MonoBehaviour
{
    public GameObject diffender;
    void OnMouseDown()
    {
        spawnDefender();
    }

    private void spawnDefender()
    {
        GameObject defender = Instantiate(diffender, transform.position, Quaternion.identity) as GameObject;
    }
}
