using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    public Rigidbody2D rig;
    public float velocidade;
    public float temponadirecao;

    float tempo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    { 
       
        tempo+=Time.deltaTime;

       
        if(tempo>= temponadirecao)
        {
            velocidade = -velocidade;

            tempo = 0f;
        }

        rig.velocity = new Vector2(velocidade, rig.velocity.y);
    }



}


