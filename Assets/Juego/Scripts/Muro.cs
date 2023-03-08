using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    [SerializeField] private GameObject muro;
    private ControlLlaves control_llaves;
    
    public void Start()
    {
        control_llaves = this.transform.parent.GetComponent<ControlLlaves>();
    }

    public void Update()
    {
        if (control_llaves.ContadorLlaves() == 2)
        {
            CambiarEstado(false);
        }
    }

    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}
