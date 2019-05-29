using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    
    public GameObject home;
    public GameObject wegwijzer;
 
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ClickButton()
    {
            StartCoroutine(MyCoroutine());    
    }
    private IEnumerator MyCoroutine()
    {
        anim.Play("Animation_home-first");
        wegwijzer.SetActive(true);
        yield return new WaitForSeconds(5.5f);
       
        home.SetActive(false);

    
    }

}
