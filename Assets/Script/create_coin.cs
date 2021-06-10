using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_coin : MonoBehaviour
{
    public GameObject coin;
    public GameObject exit_coin;
    public float spawnTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddEnemy", 1, spawnTime);
    }

    // Update is called once per frame
    void AddEnemy()
    {
        Instantiate(coin, new Vector3(exit_coin.transform.position.x, exit_coin.transform.position.y, exit_coin.transform.position.z), Quaternion.identity);
    }
}
