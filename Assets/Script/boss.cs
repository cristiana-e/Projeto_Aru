using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public int vidas = 50;




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
