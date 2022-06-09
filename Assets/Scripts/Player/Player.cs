using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed; // Velocidade do personagem
    public Rigidbody2D rig; //f�sica do player
    public Animator anim; //vari�vel para indicar a anima��o
    public GameObject bubble;
   

    private int vidas = 10;
    public Text vidasUI;
    private points ptScript;

    public bool isAfraid=true;

    //audios
    public AudioClip audio_aru_hit;
    public AudioClip audio_aru_destroy;
    public AudioClip audio_aru_jump;
    public AudioClip audio_aru_life;

    //variaveis para pulo
    bool IsGrounded;
    public int JumpCont = 2;
    public float JumpForce;//variavel para indicar for�a do pulo



    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        ptScript = GameObject.Find("Points").GetComponent<points>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        InputCheck();
        Fire();
        vidasUI.text = "Vidas: " + vidas;

    }


    //Fun��o para o movimento
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(horizontal * speed, rig.velocity.y);

        if (horizontal > 0f)
        {
            if (IsGrounded == true) //Para nao sobressair a animacao do pulo
            {
                transform.eulerAngles = new Vector2(0f, 0f);
                anim.SetInteger("transition", 1);
            }
        }

        if (horizontal < 0f)
        {
            if (IsGrounded == true)  //Para nao sobressair a animacao do pulo
            {
                transform.eulerAngles = new Vector2(0f, 180f);
                anim.SetInteger("transition", 1);
                
            }
        }

        if (horizontal == 0)
        {
            if (IsGrounded == true )  //Para nao sobressair a animacao do pulo
            {
                if (isAfraid == true) anim.SetInteger("transition", 7);
                else anim.SetInteger("transition", 0);
            }

        }
    }
    //checando a condi��o para pulo duplo
    void InputCheck()
    {
        
        if (Input.GetButtonDown("Jump") && JumpCont >= 1)
        {
            anim.SetInteger("transition", 2);
            Jump();
            
        }
    }

    //Fun��o para o pulo
    void Jump()
    {
            
            JumpCont =JumpCont-1;

            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            AudioSource.PlayClipAtPoint(audio_aru_jump, transform.position);
            IsGrounded = false;
            anim.SetInteger("transition", 2);



    }
    //Fun��o ataque
    void Fire()
    {
        if (Input.GetKeyDown("e"))
        {
            // Criando uma nova bolha
            Instantiate(bubble, transform.position, Quaternion.identity);
        }
    }

    //Verificando se o player est� colidindo com o ch�o para poder pular (evitar o pulo infinito)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            IsGrounded = true;
            JumpCont = 2;
        }
    }

    //fun��es para perder e ganhar vida, at� o limite maximo de 10 vidas

    void OnTriggerEnter2D(Collider2D outro)
    {
        //condicão para trocar a animação de idle do choro para normal
        if (outro.gameObject.tag == "cry"){
           isAfraid=false;
       }
        //fun��o ganha vida
        if (outro.gameObject.tag == "vida")
        {
            Destroy(outro.gameObject);
            vidas = vidas + 1; 
            AudioSource.PlayClipAtPoint(audio_aru_life, transform.position);

            if (vidas > 10)
            {
                vidas = 10;
            }

        }
        //fun��o perde vida, e audio quando ocorrer a colis�o e volta ao menu principal
        if (outro.gameObject.tag == "destruir")
        {
            Destroy(outro.gameObject);
            AudioSource.PlayClipAtPoint(audio_aru_hit, transform.position);
            vidas = vidas - 1;

            if (vidas < 0)
            {
                vidas = 0;
            }

            if (vidas == 0)
            {
                
                AudioSource.PlayClipAtPoint(audio_aru_destroy, transform.position);
                Destroy(this.gameObject);
                SceneManager.LoadScene("MENU");
            }
        }

        /*
        //fun��o perde vida, e audio quando ocorrer a colis�o e volta ao menu principal
        if (outro.gameObject.tag == "arvore")
        {

            vidas = vidas - 2;
            if (vidas < 0)
            {
                vidas = 0;
                AudioSource.PlayClipAtPoint(audio_aru_destroy, transform.position);
            }

            if (vidas == 0)
            {
                
                Destroy(this.gameObject);
                SceneManager.LoadScene("MENU");
            }
        }
        */
        //fun��o zera a vida, e audio quando ocorrer a colis�o e volta ao menu principal
        if (outro.gameObject.tag == "dead")
        {
            vidas = 0;

            AudioSource.PlayClipAtPoint(audio_aru_destroy, transform.position);
            Destroy(this.gameObject);
            SceneManager.LoadScene("MENU");


        }

       
    }
   
}