using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class changeContent : MonoBehaviour
{

   
    public TextMeshProUGUI textArea;
    [TextArea]
    public string NLText;
    [TextArea]
    public string ENGText;

   


    void Update()
    {

        if (selectLanguage.isNL == true)
        {
            textArea.text = NLText;
        }


        if (selectLanguage.isNL == false)
        {

            textArea.text = ENGText;
        }
    }


}
