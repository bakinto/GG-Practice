using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public void decreaseHealth(int damageManount)
    {
        GetComponent<Attacker>().health -= damageManount;
    }

}
