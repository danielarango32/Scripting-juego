using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameOverButtons : MonoBehaviour
{
    
    [SerializeField] private GameObject menuGameOver;
    

    public int numeroEscena;
    // Start is called before the first frame update
    /*void Start()
    {
        _controlMuerte.muerte += ActivMenu;
    }*/

    private void ActivMenu(object sender, EventArgs e)
    {
        menuGameOver.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(numeroEscena);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
