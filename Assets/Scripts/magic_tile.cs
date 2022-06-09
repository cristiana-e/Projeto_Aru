using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic_tile : MonoBehaviour
{
     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0f);
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Aru")){
            GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0.6f);
        }

        if (outro.gameObject.CompareTag("bubble")){
            GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0.6f);
            Destroy(outro.gameObject);
            Invoke("MyWaitingFunction",1);
        }


    }

    void MyWaitingFunction()
    {
        GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0.0f);//Stuff here happens after 1 seconds of the collision.
    }

     void OnCollisionExit2D(Collision2D outro){
        if (outro.gameObject.CompareTag("Aru")){
            GetComponent<SpriteRenderer>().color = new Color(0.78f,1f,1f,0f);
        }

    }    
}

