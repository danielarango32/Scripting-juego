using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dificultad : MonoBehaviour
{
    public int numeroEscena;
    public void OnPressFacil()
    {
        SceneManager.LoadScene(numeroEscena);
    }
    public void OnPressNormal()
    {
        SceneManager.LoadScene(numeroEscena);
    }
    public void OnPressDificil()
    {
        SceneManager.LoadScene(numeroEscena);
    }
}
