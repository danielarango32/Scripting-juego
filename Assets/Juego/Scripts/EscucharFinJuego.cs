using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;


public class EscucharFinJuego : MonoBehaviour, MMEventListener<MMGameEvent>
{ 
    public virtual void OnMMEvent(MMGameEvent e)
    {
        Debug.Log("Escucha el evento" + e.EventName);   

        if (e.EventName == "GameOverEvent")
        {

        }
        if (e.EventName == "EndTimeEvent")
        {

        }
    }

    void OnEnable() 
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable() 
    {
        this.MMEventStopListening<MMGameEvent>();
    }
}
