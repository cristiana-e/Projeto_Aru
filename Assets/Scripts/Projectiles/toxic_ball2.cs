using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toxic_ball2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -7;
    Rigidbody2D rb;

 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
        Destroy();
    }
    //Movimenta��o toxic_ball
    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    //Destrui��o toxic_ball2 ap�s 2 segundos
    void Destroy()
    {
        Destroy(gameObject, 2);
    }
}
