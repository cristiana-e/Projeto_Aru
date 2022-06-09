using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0f);
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("bolha")){
            GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0.6f);
        }
    }  
}

