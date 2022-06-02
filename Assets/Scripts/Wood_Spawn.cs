using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood_Spawn : MonoBehaviour
{
    public float spawnTime = 3.0f;
    public GameObject wood;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddEnemy", 1, spawnTime); // Repete o spawn da madeira a cada spawntime
    }

    // Nova função para clonar/spawn da madeira
    void AddEnemy()
    {
        // Variável para armazenar a posição X do objeto spawn.
        Renderer renderer = GetComponent<Renderer>();
        var x1 = transform.position.x - renderer.bounds.size.x / 2;
        var x2 = transform.position.x + renderer.bounds.size.x / 2;

        // Aleatoriamente escolhe um ponto dentro do objeto spawn
        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Criar a madeira na posição 'spawnPoint'
        Instantiate(wood, spawnPoint, Quaternion.identity);
    }
}
