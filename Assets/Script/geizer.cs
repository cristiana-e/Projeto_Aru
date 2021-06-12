using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geizer : MonoBehaviour
{
    public GameObject acid;
    // Vari�vel para conhecer qu�o r�pido n�s devemos criar novos Asteroides
    public float spawnTime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a fun��o 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

      
    }

    // Nova fun��o para clonar/spawn geizer
    void AddEnemy()
    {
         // Criar novo acido
        Instantiate(acid, transform.position, Quaternion.identity);
    }
}
