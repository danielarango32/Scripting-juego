using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public void OnPressJugar()
    {
        SceneManager.LoadScene("nivel 1", LoadSceneMode.Single);
    }
    public void OnPressInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones", LoadSceneMode.Single);
    }
    public void OnPressCreditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }
}
