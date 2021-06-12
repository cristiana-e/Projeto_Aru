using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money_attack : MonoBehaviour
{
    public int speed = -8;
    Rigidbody2D rb;

    // Start is called before the first frame update
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
        // Destroi o dinheiro quando sair da cena
        Destroy(gameObject, 2);
    }
}
