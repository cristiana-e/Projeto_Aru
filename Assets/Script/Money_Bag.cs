using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Bag : MonoBehaviour
{
    public float speed = -5;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Move();
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Soil1"))
        {
            Destroy(this.gameObject);

        }
    }

    void Move()
    {
            rb.velocity = new Vector2(0, speed);
    }
}
