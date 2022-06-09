using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_de_fogo2 : MonoBehaviour
{
    public float speed = -10;
    public float tempo = 0.75f;
    Rigidbody2D rb;

    //bool IsCollided = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
        Destroy();
    }
    //Movimento do prefab bola_de_fogo 
    void Move()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    //Destrui��o do prefab bola_de_fogo, ap�s 2 segundos
    void Destroy()
    {
        Destroy(gameObject, tempo);
    }
}
