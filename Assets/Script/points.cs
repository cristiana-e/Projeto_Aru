using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class points : MonoBehaviour
{
    public int pontos;
    public Text pontosUI;
    public Text recordeUI;


    // Update is called once per frame
    void Update()
    {
        if (pontos > PlayerPrefs.GetInt("RECORDE"))
        {
            PlayerPrefs.SetInt("RECORDE", pontos);
        }

        pontosUI.text = "PONTOS: " + pontos;
        recordeUI.text = "RECORDE: " + PlayerPrefs.GetInt("RECORDE");
    }
}
