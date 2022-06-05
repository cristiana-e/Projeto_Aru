using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = -5;
    Rigidbody2D rb;

    //check the collision
    bool IsCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //get rigidbody

    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Soil1")) //checking if the coin is in collision with the ground
        {
            IsCollided = true;// get a true value for the collision with the ground
            Move();

        }
    }

    void Move()
    {
        if (IsCollided == true)
        {
            rb.velocity = new Vector2(speed, 0); //move at 'x' axis if is collided with the ground

        }

    }

    void FixedUpdate()
    {
        rb.rotation -= -5.0f; //coin rotation movement
    }

    void Destroy()
    {
        Destroy(gameObject,2);
    }
}


