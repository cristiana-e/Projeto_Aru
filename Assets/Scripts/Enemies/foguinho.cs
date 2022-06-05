using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foguinho : MonoBehaviour
{
    public Rigidbody2D rig;
    public float velocidade = 3.0f;
    public float temponadirecao = 0.5f;//quanto tempo ele permanece na dire��o
    float tempo;

    //audio
    private points ptScript;
    public AudioClip audio_fogo_destroy;

  

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ptScript = GameObject.Find("Points").GetComponent<points>();
    }

    // Update is called once per frame
    void Update()
    {
        walk();
    }
    //fun��o Movimenta��o Flame_move
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

    // FUn��o destrui��o flame_move, contador de pontua��o e audio quando � destruido
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
        {
            ptScript.pontos++;
            AudioSource.PlayClipAtPoint(audio_fogo_destroy, transform.position);
            Destroy(outro.gameObject);
            Destroy(this.gameObject);
               

        }
    }
 
    
}
