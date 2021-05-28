using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject saw;
    // Vari�vel para conhecer qu�o r�pido n�s devemos criar novos Asteroides
    public float spawnTime = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Chamar a fun��o 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);

        InvokeRepeating("AddEnemy", 1, spawnTime);
    }

    // Nova fun��o para clonar/spawn uma serra
    void AddEnemy()
    {
        // Vari�vel para armazenar a posi��o Y do objeto spawn.
        Renderer renderer = GetComponent<Renderer>();
        var y1 = transform.position.y - renderer.bounds.size.y / 2;
        var y2 = transform.position.y + renderer.bounds.size.y / 2;

        // Aleatoriamente escolhe um ponto dentro do objeto spawn
        var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));

        // Criar uma serra na posi��o 'spawnPoint'
        Instantiate(saw, spawnPoint, Quaternion.identity);
    }
}
