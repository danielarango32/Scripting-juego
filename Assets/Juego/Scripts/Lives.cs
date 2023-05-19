using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    private controlMuerte corazon;

    public static Lives inst;
    private void Awake()
    {
        if (Lives.inst == null)
        {
            Lives.inst = this;
            DontDestroyOnLoad(gameObject);
            corazon = GetComponent<controlMuerte>();
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
