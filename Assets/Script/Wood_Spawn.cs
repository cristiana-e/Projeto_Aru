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
        InvokeRepeating("AddEnemy", 1, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddEnemy()
    {
        Renderer renderer = GetComponent<Renderer>();
        var x1 = transform.position.x - renderer.bounds.size.x / 2;
        var x2 = transform.position.x + renderer.bounds.size.x / 2;

        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        Instantiate(wood, spawnPoint, Quaternion.identity);
    }
}
