using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public GameObject bubble; // A ser preenchido via Inspector com o prefab bubble
    public int speed = 10;  // Velocidade de saida do ataque do player

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>(); //call rigidbody
        rb.velocity = new Vector2(speed, 0); //indicate the axis and the speed for the movement 
    }

    //Fun��o para destruir ataque do player quando sair da cena 
    void Destroy()
    {
        Destroy(gameObject, 3);
    }

  

}
