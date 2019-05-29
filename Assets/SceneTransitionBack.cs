using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransitionBack : MonoBehaviour
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
        home.SetActive(true);
        yield return new WaitForSeconds(3f);
        wegwijzer.SetActive(false);
        

    }
}
