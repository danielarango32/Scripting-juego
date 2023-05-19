using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dificultad : MonoBehaviour
{
    public void OnPressFacil()
    {
        SceneManager.LoadScene("nivel 1 facil");
    }
    public void OnPressNormal()
    {
        SceneManager.LoadScene("nivel 1");
    }
    public void OnPressDificil()
    {
        SceneManager.LoadScene("nivel 1 hard");
    }
}
