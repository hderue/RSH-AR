using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickAnimation : MonoBehaviour
{
   

    public void PlayAnimation()
    {

        gameObject.GetComponent<Animator>().Play("Button click", -1, 0);
    }
}
