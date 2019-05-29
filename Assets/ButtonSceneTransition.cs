using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneTransition : MonoBehaviour
{
  public void PreviousScene()
    {
        SceneManager.LoadScene("Welkom");
    }
}
