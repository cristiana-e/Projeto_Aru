using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flame_atc : MonoBehaviour
{
    public GameObject bola_de_fogo;
    public GameObject exit_flame;
    // Vari�vel para conhecer qu�o r�pido n�s devemos criar novos Asteroides
    public float spawnTime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a fun��o 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

    }

    // Nova fun��o para clonar/spawn uma serra
    void AddEnemy()
    {
        // Criar uma serra
        Instantiate(bola_de_fogo, exit_flame.transform.position, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
        {
            Destroy(outro.gameObject);
            Destroy(this.gameObject);

        }
    }
}
