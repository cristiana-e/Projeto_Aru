using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        Move();
        Destroy();
    }
    void Move()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Soil2")
        {
            Destroy(this.gameObject);
        }
    }

    void Destroy()
    {
        Destroy(gameObject, 3);
    }
}
