using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] Attacker attacker;
    bool spawn = true;

    void Start()
    {
        StartCoroutine(spawnCoroutine());        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    IEnumerator spawnCoroutine()
    {
        while (spawn)
        { 
            yield return new WaitForSeconds(UnityEngine.Random.Range(min, max));
            spoawnAttacker();
        }
    }


    private void spoawnAttacker()
    {
        Instantiate(attacker, transform.position, Quaternion.identity);
    }
}
