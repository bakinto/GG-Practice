using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 20f;
    public GameObject fx;

    public void decreaseHealth(int damageManount)
    {
       health -= damageManount;
        if (health <= 0)
        {
            var vfx = Instantiate(fx, transform.position, Quaternion.identity) as GameObject;
            Destroy(vfx, 1f);
            Destroy(gameObject);
        }
    }
    IEnumerable deathFx()
    {
        yield return new WaitForSeconds(2f);

    }

}
