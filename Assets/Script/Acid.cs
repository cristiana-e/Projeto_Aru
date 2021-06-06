using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    public float speed = 2;


    // Start is called before the first frame update
    void Start()
    {
        // Ajusta a velocidade Y para fazer a bala se mover para cima
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Soil2")
        {
            Destroy(this.gameObject);
        }
    }

}
