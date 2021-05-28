using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject saw;
    // Variável para conhecer quão rápido nós devemos criar novos Asteroides
    public float spawnTime = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

        InvokeRepeating("AddEnemy", 1, spawnTime);
    }

    // Nova função para clonar/spawn uma serra
    void AddEnemy()
    {
        // Variável para armazenar a posição Y do objeto spawn.
        Renderer renderer = GetComponent<Renderer>();
        var y1 = transform.position.y - renderer.bounds.size.y / 2;
        var y2 = transform.position.y + renderer.bounds.size.y / 2;

        // Aleatoriamente escolhe um ponto dentro do objeto spawn
        var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));

        // Criar uma serra na posição 'spawnPoint'
        Instantiate(saw, spawnPoint, Quaternion.identity);
    }
}
