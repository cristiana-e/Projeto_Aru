using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toxic_atc : MonoBehaviour
{
    public GameObject toxic_ball;
    public GameObject toxic_attack02;
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
        Instantiate(toxic_ball, toxic_attack02.transform.position, Quaternion.identity);
    }
}
