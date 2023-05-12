using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAudio : MonoBehaviour
{
    AudioSource _audiosource;
    public static ScriptAudio inst;

    private void Awake()
    {
        if (ScriptAudio.inst == null)
        {
            ScriptAudio.inst = this;
            DontDestroyOnLoad(gameObject);
            _audiosource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
