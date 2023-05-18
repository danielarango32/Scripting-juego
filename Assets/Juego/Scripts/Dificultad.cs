using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dificultad : MonoBehaviour
{
    public void OnPressFacil()
    {
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }
    public void OnPressNormal()
    {
        SceneManager.LoadScene("Instrucciones", LoadSceneMode.Single);
    }
    public void OnPressDificil()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }
    public void OnPressDificultad()
    {
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }
}
