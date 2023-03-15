using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levels : MonoBehaviour
{
    public int numeroEscena;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            //SceneManager.LoadScene("nivel 2");
            SceneManager.LoadScene(numeroEscena);
        }
        
    }
}



