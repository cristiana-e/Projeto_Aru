using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public int speed = -4;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.rotation = 45f;

        Move();
        Destroy();
    }
    //Fun��o Movimento
    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void Destroy()
    {
        // Destroi a serra ap�s 10s de ter sido lan�ada
        Destroy(gameObject, 10);
    }

     void FixedUpdate()
    {
        rb.rotation -= 10.0f;
    }
}
