using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; // Velocidade do personagem
    public float JumpForce;
    public Rigidbody2D rig; //f�sica do player
    public Animator anim; //vari�vel para indicar a anima��o
    public GameObject bubble; 

    bool IsJumping;
    private int JumpCont = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Fire();
    }

    //Fun��o para o movimento
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(horizontal * speed, rig.velocity.y);

        if (horizontal > 0f)
        {
            if (IsJumping == false) //Para nao sobressair a animacao do pulo
            {
                transform.eulerAngles = new Vector2(0f, 0f);
                anim.SetInteger("transition", 1);
            }
        }

        if (horizontal < 0f)
        {
            if (IsJumping == false) //Para nao sobressair a animacao do pulo
            {
                transform.eulerAngles = new Vector2(0f, 180f);
                anim.SetInteger("transition", 1);
            }
        }

        if (horizontal == 0)
        {
            if (IsJumping == false) //Para nao sobressair a animacao do pulo
            {
                anim.SetInteger("transition", 0);
            }

        }
    }

    //Fun��o para o pulo
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsJumping==false)
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            IsJumping = true;

        }
    }

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
            IsJumping = false;
            JumpCont = 0;
        }
    }


}
