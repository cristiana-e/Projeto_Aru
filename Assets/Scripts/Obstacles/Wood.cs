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
    //fun��o para informar quando colidir com o solo
    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Soil1"))
        {
            IsCollided = true;
            Move();
            
        }
   }
    //fun��o para movimenta��o
    void Move()
    {
        if (IsCollided == true)
        {
            rb.velocity = new Vector2(speed, 0);
            
        }
        
    }
    //fun��o para rolar
    void FixedUpdate()
    {
        rb.rotation -= -5.0f;
    }
}

