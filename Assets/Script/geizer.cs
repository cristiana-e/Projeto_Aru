using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geizer : MonoBehaviour
{
    public GameObject acid;
    // Variável para conhecer quão rápido nós devemos criar novos Asteroides
    public float spawnTime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

      
    }

    // Nova função para clonar/spawn geizer
    void AddEnemy()
    {
         // Criar novo acido
        Instantiate(acid, transform.position, Quaternion.identity);
    }
}
