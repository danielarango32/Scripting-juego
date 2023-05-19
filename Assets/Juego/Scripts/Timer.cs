using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    private int contadorTime = 60;

    [SerializeField] private TMP_Text timer;
    
    public event EventHandler _muerte;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(contadorTime);
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1);
        contadorTime --;
        timer.text = contadorTime.ToString();
        Debug.Log(contadorTime);
        StartCoroutine(Countdown());

        if (contadorTime <= 0)
        {
            _muerte?.Invoke(this,EventArgs.Empty);
        }
        
        
    }
}
