using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZucciniMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage = 10;


    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        var health = col.GetComponent<Health>();
        health.decreaseHealth(damage);
        Debug.Log(col.GetComponent<Attacker>().health);
    }
}
