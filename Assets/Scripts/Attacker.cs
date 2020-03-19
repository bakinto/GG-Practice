using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float speed = 1f;
    public float health = 20f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(health <= 0)
        {
//            Debug.Log("zuccini killed!!");
        }
    }

    void setCurrentSpeed(float speed)
    {
        this.speed = speed;
    }

    //////////////////////////////////////////////// health management ///////////////////////////////////////////////

    

    public void decreaseHealth(float damageManount)
    {
        this.health -= damageManount;
    }
   

}
