using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_de_fogo : MonoBehaviour
{
    [Header("Atributos Física")]
    public Vector3 accelerationVector;
    public Vector3 velocityVector2;
    
    [Header("Atributos Unity")]
    public float tempo = 1.5f;
    Rigidbody2D rb;

    //bool IsCollided = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy();
    }
    //Movimento do prefab bola_de_fogo 

    void FixedUpdate()
    {
        UpdateVelocity () ;

        transform.position += velocityVector2 * Time.deltaTime;
    }

    void UpdateVelocity(){
        velocityVector2 += accelerationVector * Time.deltaTime;
    }

    //Destrui��o do prefab bola_de_fogo, ap�s 2 segundos
    void Destroy()
    {
        Destroy(gameObject, tempo);
    }
}
