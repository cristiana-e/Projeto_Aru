using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foguinho : MonoBehaviour
{
    public Rigidbody2D rig;
    public float velocidade = 3.0f;
    public float temponadirecao = 0.5f;
    float tempo;
    


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        walk();
    }

    void walk()
    {
        tempo += Time.deltaTime;


        if (tempo >= temponadirecao)
        {
            velocidade = -velocidade;

            tempo = 0f;
        }

        rig.velocity = new Vector2(velocidade, rig.velocity.y);
    }

    
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
            {
               Destroy(outro.gameObject);
               Destroy(this.gameObject);

            }
    }
 
    
}
