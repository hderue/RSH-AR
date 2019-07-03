using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectLanguage : MonoBehaviour
{

    public static bool isNL;
    public GameObject emptyLayer;

    // Update is called once per frame
    public void SetENG()
    {
        isNL = false;
        DontDestroyOnLoad(emptyLayer);
        Debug.Log("isNL = false");
      
    }
    public void SetNL()
    {
        isNL = true;
        DontDestroyOnLoad(emptyLayer);
        Debug.Log("isNL = true");

    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("Welkom");
    }
}

