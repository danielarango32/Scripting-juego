using System.Collections;
using System.Collections.Generic;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class ControlTiempo : MonoBehaviour
{
    private int tiempo;
    void Start()
    {
        StartCoroutine(ContarTiempo(10));
    }

    IEnumerator ContarTiempo(int tiempo_final)
    {
        Debug.Log("Tiempo " + tiempo);
        if (tiempo<tiempo_final)
        {
            tiempo++;
            yield return new WaitForSecondsRealtime(1);  
            StartCoroutine(ContarTiempo(tiempo_final));
        }
        else
        {
            Debug.Log("Fin del Tiempo");

        }

    }

}
