using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    bool spawn = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update here !!");
        while (spawn)
        {
            StartCoroutine(spawnCoroutine());
            
        }
    }

    IEnumerator spawnCoroutine()
    {
        spoawnAttacker();
       
        yield return new WaitForSeconds(UnityEngine.Random.Range(min, max));
    }

    private void spoawnAttacker()
    {
        Debug.Log("Attacker Spawned!!");
    }
}
