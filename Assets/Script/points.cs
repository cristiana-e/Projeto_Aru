using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class points : MonoBehaviour
{
    public int pontos;
    public Text pontosUI; //Mostra pontos na tela de jogo
    public Text recordeUI; //Mostra pontos na tela de recorde


    // Update is called once per frame
    void Update()
    {   //Compara a todo momento o recorde com os pontos e caso os pontos sejam maior que o recorde, substitui o recorde
        if (pontos > PlayerPrefs.GetInt("RECORDE")) 
        {
            PlayerPrefs.SetInt("RECORDE", pontos);
        }
        //Incrementa o pontos a cada e se o recorde for batido encrementa o recorde também
        pontosUI.text = "PONTOS: " + pontos;
        recordeUI.text = "RECORDE: " + PlayerPrefs.GetInt("RECORDE");
    }
}
