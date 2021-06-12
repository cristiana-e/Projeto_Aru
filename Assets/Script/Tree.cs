using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{


    private int vidas = 5;




    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
        {
            Destroy(outro.gameObject);
            vidas = vidas - 1;

            if (vidas == 0)

            {
                Destroy(this.gameObject);
            }
        }
    }
}
