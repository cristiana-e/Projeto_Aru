using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foguinho : MonoBehaviour
{
    public Rigidbody2D rig;
    public float velocidade;
    public float temponadirecao;
    public float Jump;
    public float IntervaloJump;
    float tempo;
    float ContJump;

    bool IsGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        walk();
        Jumping();
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

    void Jumping()
    {
        ContJump += Time.deltaTime;

        if (ContJump >= IntervaloJump && IsGrounded == false)
        {

            IsGrounded = true;

        }

        rig.AddForce (new Vector2(0f, Jump), ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            IsGrounded = false;
        }
    }

}
