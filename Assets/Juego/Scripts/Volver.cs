using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Volver : MonoBehaviour
{
public void OnPressVolver()
    {
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }
}
