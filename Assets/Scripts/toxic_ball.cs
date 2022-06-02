using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toxic_ball : MonoBehaviour
{
    public float speed = -5;
    Rigidbody2D rb;

    //bool IsCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
        Destroy();
    }
    //Movimentação toxic_ball
    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    //Destruição toxic_ball após 2 segundos
    void Destroy()
    {
        Destroy(gameObject, 2);
    }
}

