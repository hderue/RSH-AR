using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfobuttonClick : MonoBehaviour
{
    public GameObject InformatieObject;

    public void PlayInfoAnimation()
    {

       if( InformatieObject != null)
        {
            Animator animator = InformatieObject.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);
            }
        }
    }
}
