using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;


public class controlMuerte : MonoBehaviour , MMEventListener<CorgiEngineEvent>,MMEventListener<PickableItemEvent>
{
    [SerializeField] 
    
    private List<GameObject> corazon;

    private int vidas;
    
    private int contador_llaves;

    [SerializeField] private int total_llaves;

    public event EventHandler muerte;
    
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
                contador_llaves = 0;
                corazon[vidas].SetActive(false);
            }

            if (vidas == 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("GameOver");
                muerte?.Invoke(this,EventArgs.Empty);
                
            }
        }
        
        Debug.Log(vidas);
        Debug.Log(e.EventType);
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log("Pick");
        contador_llaves++;
        Debug.Log("contador llaves" + contador_llaves + " vidas" + vidas);

        if (contador_llaves == total_llaves && vidas+1<=corazon.Count)
        {
            corazon[vidas].SetActive(true);
            vidas++;
            contador_llaves = 0;
            
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
