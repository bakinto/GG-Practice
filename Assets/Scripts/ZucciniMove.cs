using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZucciniMove : MonoBehaviour
{
    [SerializeField] float speed;


    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name + "hit");
    }
}
