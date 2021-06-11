using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toxic_atc2 : MonoBehaviour
{
    public GameObject toxic_ball2;
    public GameObject toxic_attack01;
    // Variável para conhecer quão rápido nós devemos criar novos Asteroides
    public int spawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

    }

    // Nova função para clonar/spawn ataque
    void AddEnemy()
    {
        // Criar ataque
        Instantiate(toxic_ball2, toxic_attack01.transform.position, Quaternion.identity);
    }
}
