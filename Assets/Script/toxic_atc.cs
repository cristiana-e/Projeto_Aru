using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toxic_atc : MonoBehaviour
{
    public GameObject toxic_ball;
    public GameObject exit02;
    public GameObject toxic_ball2;
    public GameObject exit01;
    public int spawnTime2 = 2;
    public int spawnTime = 5;
    private points ptScript;
    public AudioClip audio_toxic_destroy;
    public AudioClip audio_toxic_hit;

    private int vidas = 3;

    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);
        InvokeRepeating("AddEnemy", 1, spawnTime2);
        ptScript = GameObject.Find("Points").GetComponent<points>();
    }

    // Nova função para clonar/spawn ataque
    void AddEnemy()
    {
        // Criar ataque
        Instantiate(toxic_ball,exit02.transform.position, Quaternion.identity);
        Instantiate(toxic_ball2, exit01.transform.position, Quaternion.identity);

    }
    // Função para destruir toxic_atc, depois de 3 ataques, contador de pontos, audio quando toxic_atc perde vida e audio de destruição
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
        {
            ptScript.pontos++;
            
            Destroy(outro.gameObject);
            vidas = vidas - 1;
            AudioSource.PlayClipAtPoint(audio_toxic_hit, transform.position);

            if (vidas == 0)
               
            {
                AudioSource.PlayClipAtPoint(audio_toxic_destroy, transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
