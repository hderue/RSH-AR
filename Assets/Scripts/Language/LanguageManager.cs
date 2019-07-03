using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{

    public ContentLanguage[] languages;
    public bool[] selectedLanguage;
    public Text[] areas;

    // Start is called before the first frame update
    void Start()
    {
        selectedLanguage = new bool[languages.Length];
    }

    // Update is called once per frame
    void Update()
    {
        if(selectedLanguage[0] == true)
        {
            areas[0].text = "asfsg";
            areas[1].text = "asfsg";
            areas[2].text = "asfsg";
        }
    }
}
