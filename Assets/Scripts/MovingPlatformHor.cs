using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformHor : MonoBehaviour
{
    public Rigidbody2D rig;
    public float velocidade = 3.0f;
    public float temponadirecao = 10f;//quanto tempo ele permanece na dire��o
    float tempo;

    //audi

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    //fun��o Movimenta��o Flame_move
    void move()
    {
        tempo += Time.deltaTime;


        if (tempo >= temponadirecao)
        {
            velocidade = -velocidade;

            tempo = 0f;
        }

        rig.velocity = new Vector2(velocidade, rig.velocity.y);
    }
 
    
}
