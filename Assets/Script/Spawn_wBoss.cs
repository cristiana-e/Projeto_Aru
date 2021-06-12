using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_wBoss : MonoBehaviour
{
    public GameObject wood;
    
    public float spawnTime = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

    }

    
    void AddEnemy()
    {
        // Variável para armazenar a posição Y do objeto spawn.
        Renderer renderer = GetComponent<Renderer>();

        var spawnPoint = new Vector2(transform.position.x, transform.position.y);

        Instantiate(wood, spawnPoint, Quaternion.identity);
    }
}
