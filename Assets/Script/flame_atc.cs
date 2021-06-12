using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flame_atc : MonoBehaviour
{
    public GameObject bola_de_fogo;
    public GameObject exit_flame;
    // Variável para conhecer quão rápido nós devemos criar novos Asteroides
    public float spawnTime = 2.0f;
    private int vidas = 2;
    private points pt;
    public AudioClip audio_fogo_destroy;
    public AudioClip audio_fogo_hit;



    // Start is called before the first frame update
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("AddEnemy", 1, spawnTime);
        pt = GameObject.Find("Points").GetComponent<points>();
    }



    // Nova função para clonar/spawn ataque bola_de_fogo
    void AddEnemy()
    {
        // Criar uma serra
        Instantiate(bola_de_fogo, exit_flame.transform.position, Quaternion.identity);
    }
    // Função para destruir flame_atc, depois de 2 ataques, contador de pontos, e audio quando flame_atc perde vida
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "bubble")
        {
            pt.pontos++;
            Destroy(outro.gameObject);

            AudioSource.PlayClipAtPoint(audio_fogo_hit, transform.position);
            vidas = vidas - 1;


            if (vidas == 0)

            {
                AudioSource.PlayClipAtPoint(audio_fogo_destroy, transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
