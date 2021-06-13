using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    //funções que chamam as cenas
    public void OnClickStartGame()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("Menu");
    }

   
}
