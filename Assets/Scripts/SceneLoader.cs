using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class SceneLoader : MonoBehaviour
{

    public void LoadLevel()
    {
        SceneManager.LoadScene("AR");
    }

    public void LoadForm()
    {
        SceneManager.LoadScene("Feedback");
    }

    public void endScene()
    {
        SceneManager.LoadScene("Einde");
    }
}