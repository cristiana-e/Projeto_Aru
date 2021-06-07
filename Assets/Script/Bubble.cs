using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public GameObject bubble; // A ser preenchido via Inspector com o prefab bubble
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
     

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
