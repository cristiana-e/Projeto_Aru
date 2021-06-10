using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = -5;
    Rigidbody2D rb;

    bool IsCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Soil1"))
        {
            IsCollided = true;
            Move();

        }
    }

    void Move()
    {
        if (IsCollided == true)
        {
            rb.velocity = new Vector2(speed, 0);

        }

    }

    void FixedUpdate()
    {
        rb.rotation -= -5.0f;
    }
}


