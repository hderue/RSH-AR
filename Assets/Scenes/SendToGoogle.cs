using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SendToGoogle : MonoBehaviour
{


    public GameObject drop;
    public GameObject dropModel;
    public GameObject dropAR;
 

    private int Dropper;
    private int DropperModel;
    private int DropperAR;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSfyVtiVtOOgpz8qxQqm0r--ulrj8u2B_tXldNNAQhvGmb3O0g/formResponse";

    IEnumerator Post(int drop, int dropModel, int dropAR)
    {
        WWWForm form = new WWWForm();
        
        form.AddField("entry.756974309", dropModel);
        form.AddField("entry.558954491", drop);
        form.AddField("entry.1663115365", dropAR);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }

    public void Send()
    {
   

        Dropper = drop.GetComponent<TMP_Dropdown>().value;
        DropperModel = dropModel.GetComponent<TMP_Dropdown>().value;
        DropperAR = dropAR.GetComponent<TMP_Dropdown>().value;



        StartCoroutine(Post(Dropper, DropperModel, DropperAR));

    }

}
