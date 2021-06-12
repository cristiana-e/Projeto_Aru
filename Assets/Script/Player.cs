using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed; // Velocidade do personagem
    public float JumpForce;
    public Rigidbody2D rig; //física do player
    public Animator anim; //variável para indicar a animação
    public GameObject bubble;
    private int vidas = 10;
    public Text vidasUI;
    private points ptScript;


    //bool IsJumping;
    bool IsGrounded;
    public int JumpCont = 2;



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


    //Função para o movimento
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
                anim.SetInteger("transition", 0);
            }

        }
    }

    //C
    void InputCheck()
    {
        
        if (Input.GetButtonDown("Jump") && JumpCont >= 1)
        {
            anim.SetInteger("transition", 2);
            Jump();
            
        }
    }

    //Função para o pulo
    void Jump()
    {
            
            JumpCont =JumpCont-1;

            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            IsGrounded = false;
            anim.SetInteger("transition", 2);



    }

    void Fire()
    {
        if (Input.GetKeyDown("e"))
        {
            // Criando uma nova bolha
            Instantiate(bubble, transform.position, Quaternion.identity);
        }
    }

    //Verificando se o player está colidindo com o chão para poder pular (evitar o pulo infinito)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            IsGrounded = true;
            JumpCont = 2;
        }
    }

    //perde vida

    void OnTriggerEnter2D(Collider2D outro)
    {

        if (outro.gameObject.tag == "vida")
        {
            Destroy(outro.gameObject);
            vidas = vidas + 1;

            if (vidas > 10)
            {
                vidas = 10;
            }

        }

        if (outro.gameObject.tag == "destruir")
        {
            Destroy(outro.gameObject);
            vidas = vidas - 1;

            if (vidas < 0)
            {
                vidas = 0;
            }

            if (vidas == 0)
            {
                // vidasUI.text = "Vidas: " + vidas;
                Destroy(this.gameObject);
            }
        }


        if (outro.gameObject.tag == "arvore")
        {

            vidas = vidas - 2;
            if (vidas < 0)
            {
                vidas = 0;
            }

            if (vidas == 0)
            {
              
                Destroy(this.gameObject);
                SceneManager.LoadScene("MENU");
            }
        }
        if (outro.gameObject.tag == "dead")
        {
            vidas = 0;

          
            Destroy(this.gameObject);
            SceneManager.LoadScene("MENU");


        }
        if (outro.gameObject.tag == "Wood")
        {
            ptScript.pontos--;
        }
    }
   
}