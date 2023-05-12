using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class BotonPausa1 : MonoBehaviour
{

    public virtual void PauseButtonAction()
    {
        StartCoroutine(PauseButtonCo());
    }


    protected virtual IEnumerator PauseButtonCo()
    {
        yield return null;
        CorgiEngineEvent.Trigger(CorgiEngineEventTypes.TogglePause);
    }
}
