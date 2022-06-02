using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood_boss : MonoBehaviour
{
    public int speed = 4;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.rotation = 45f;

        Move();
        
    }
    //fun��o para movimenta��o
    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    //fun��o para rolar
    void FixedUpdate()
    {
        rb.rotation -= 5.0f;
    }
    //fun��o para destruir quando fora da cena
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
