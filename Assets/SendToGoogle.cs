using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogle : MonoBehaviour
{
    

    public GameObject drop;



    private int Dropper;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSegNpRZlD7nQOrt-FD9-XTktpOOBoa1_4wTpC9R6DASl9RAUQ/formResponse";

    IEnumerator Post(int drop)
    {
        WWWForm form = new WWWForm();

        form.AddField("entry.424055048", drop);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }

    public void Send()
    {
       
        Dropper = drop.GetComponent<Dropdown>().value;


        StartCoroutine(Post(Dropper));

    }

}
