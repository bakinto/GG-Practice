using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZucciniMove : MonoBehaviour
{
    [SerializeField] float speed;
//    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
