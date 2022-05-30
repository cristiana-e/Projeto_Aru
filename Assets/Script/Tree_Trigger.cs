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

    //fun��o do movimento realizado ao colidir com o player
    void Hammer()
    {
        if (IsTrigger == true)
        {
            tree.gameObject.transform.Rotate(new Vector3 (0,0,45));
            IsTrigger = false;
            
        }
    }

    //condi��o para fazer a arvore voltar ao normal
    /*
    void Reset()
    {
        tree.gameObject.transform.Rotate(new Vector3(0, 0, 0));
    }
    */

    //checando se o trigger entrou em contato com o player
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Aru"))
        {
            IsTrigger = true;
        }
        
    }


    //fazendo o movimento de machado quando o trigger entra em contato com o player
/*
    void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Aru"))
        {
            tree.gameObject.transform.Rotate(new Vector3(0, 0,-90));
        }
    }
*/
   
}
