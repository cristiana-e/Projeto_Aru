using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public Rigidbody2D rig;


    public AudioClip audio_coin;
    private points ptScript;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ptScript = GameObject.Find("Points").GetComponent<points>();

    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Aru")
        {
            ptScript.pontos = ptScript.pontos+5;
            AudioSource.PlayClipAtPoint(audio_coin, transform.position);
            Destroy(this.gameObject);
               

        }
    }
}
