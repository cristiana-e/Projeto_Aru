using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    public float speed = 10; // Velocidade do ataque


    // Start is called before the first frame update
    void Start()
    {
        Move();
        Destroy();
    }
    //Movimento do prefab acido
    void Move()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }
    //Destruir o prefab, em contato com o solo
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Soil2")
        {
            Destroy(this.gameObject);
        }
    }
    //Destruir o prefab acido após 3 seg, pois tem alguns que não estão em contato com o solo
    void Destroy()
    {
        Destroy(gameObject, 3);
    }
}
