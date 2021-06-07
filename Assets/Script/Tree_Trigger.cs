using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Trigger : MonoBehaviour
{
    public bool IsTrigger = false;
    public GameObject tree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hammer();   
    }

    void Hammer()
    {
        if (IsTrigger == true)
        {
            tree.gameObject.transform.Rotate(new Vector3 (0,0,90));
            IsTrigger = false;
            
        }
    }

    void Reset()
    {
        tree.gameObject.transform.Rotate(new Vector3(0, 0, 0));
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Aru"))
        {
            IsTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Aru"))
        {
            tree.gameObject.transform.Rotate(new Vector3(0, 0,-90));
        }
    }
}
