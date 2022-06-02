using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money_attack : MonoBehaviour
{
    public int speed = -8;//velocidade de saida do ataque
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
        Destroy();
    }
    //Fun��o movimenta��o 
    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void Destroy()
    {
        // Destroi o dinheiro, ap�s 2 segundos
        Destroy(gameObject, 3);
    }
}
