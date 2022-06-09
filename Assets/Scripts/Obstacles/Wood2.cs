using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood2 : MonoBehaviour
{
    [Header("Atributos Física")]
    public Vector3 velocidade;
    public Vector3 aceleracao;
    private Vector3 peso;
    public float massa;
    public Vector3 g;
    public Vector3 resultante;
    public Vector3 f2;
    public Vector3 f3;

    [Header("Atributos Unity")]
    public float speed = -5;
    Rigidbody2D rb;

    bool IsCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
  
    }

    void FixedUpdate()
    {
        rb.rotation -= -5.0f;
        UpdateAceleracao();
        UpdateVelocity ();
        transform.position += velocidade * Time.deltaTime;
    }

    void UpdateVelocity()
    {
        velocidade += aceleracao * Time.deltaTime;

    }

    void UpdateAceleracao()
    {
        peso = massa * g;
        resultante = peso + f2 + f3;
        aceleracao = resultante / massa;
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
}
