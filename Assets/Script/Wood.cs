using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public float speed = -5;
    Rigidbody2D rb;

    bool IsCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
  
    }
    //função para informar quando colidir com o solo
    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Soil1"))
        {
            IsCollided = true;
            Move();
            
        }
   }
    //função para movimentação
    void Move()
    {
        if (IsCollided == true)
        {
            rb.velocity = new Vector2(speed, 0);
            
        }
        
    }
    //função para rolar
    void FixedUpdate()
    {
        rb.rotation -= -5.0f;
    }
}

