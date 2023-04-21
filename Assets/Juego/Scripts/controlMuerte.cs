using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;


public class controlMuerte : MonoBehaviour , MMEventListener<CorgiEngineEvent>,MMEventListener<PickableItemEvent>
{
    [SerializeField] 
    
    private List<GameObject> corazon;

    private int vidas;
    
    private int contador_estrellas;

    [SerializeField] private int total_estrellas;
    
    // Start is called before the first frame update
    void Start()
    {
        vidas = corazon.Count;
        
    }

    public virtual void OnMMEvent(CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            if (vidas-1>=0)
            {
                vidas--;
                contador_estrellas = 0;
                corazon[vidas].SetActive(false);
            }

            if (vidas == 0)
            {
                Debug.Log("Game Over");
            }
        }
        
        Debug.Log(vidas);
        Debug.Log(e.EventType);
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");
        contador_estrellas++;
        Debug.Log("contador estrellas" + contador_estrellas + " vidas" + vidas);

        if (contador_estrellas == total_estrellas && vidas+1<=corazon.Count)
        {
            corazon[vidas].SetActive(true);
            vidas++;
            contador_estrellas = 0;
            
        }
    }

    private void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
        this.MMEventStartListening<PickableItemEvent>();
    }

    private void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
        this.MMEventStopListening<PickableItemEvent>();
    }
}
