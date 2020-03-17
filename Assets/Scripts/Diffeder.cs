using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diffeder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    [SerializeField] int speed = 5;
    public GameObject gun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shootProjectile()
    {
        GameObject obj = Instantiate(projectile, gun.transform.position, Quaternion.identity) as GameObject;
    }
}
