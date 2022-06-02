using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_attack : MonoBehaviour
{
    public GameObject money;
    public float spawnTime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);
    }

    // Nova função para spawn da cédula
    void AddEnemy()
    {
        // Criar uma cédula
        Instantiate(money, transform.position, Quaternion.identity);
    }

}
