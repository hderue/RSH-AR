using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentLanguage : MonoBehaviour
{

    public LanguageManager LM;
    public int languageNumber;
 
   

    public void ButtonClick()
    {
        LM.selectedLanguage[languageNumber] = true;
    }
}
