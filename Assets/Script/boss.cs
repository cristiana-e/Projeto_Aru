using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class boss : MonoBehaviour
{
    public int vidas = 50;
    public AudioClip audio_boss_hit;
    public AudioClip audio_boss_destroy;



    //Função para destruir o Boss, utilizando a decrementação da vida, e também os som emitido pelo boss quando derrotado
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
        {
            Destroy(outro.gameObject);
            AudioSource.PlayClipAtPoint(audio_boss_hit, transform.position);
            vidas = vidas - 1;

            if (vidas == 0)

            {
                AudioSource.PlayClipAtPoint(audio_boss_destroy, transform.position);
                Destroy(this.gameObject);
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
