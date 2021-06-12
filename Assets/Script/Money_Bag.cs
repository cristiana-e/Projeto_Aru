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
        Destroy();

    }

    void Update()
    {
        Move();
    }
    //Fun��o Destrui��o quando coledir com o ch�o
    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Soil1"))
        {
            Destroy(this.gameObject);

        }
    }
    //Fun��o Movimenta��o
    void Move()
    {
            rb.velocity = new Vector2(0, speed);
    }
    //Fun��o Destrui��o ap�s 4 segundos
    void Destroy()
    {
        Destroy(gameObject, 4);
    }
}
