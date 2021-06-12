using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_de_fogo : MonoBehaviour
{
    public float speed = -10;
    Rigidbody2D rb;

    //bool IsCollided = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
        Destroy();
    }

    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }


    void Destroy()
    {
        Destroy(gameObject, 2);
    }
}
