using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SendToGoogle : MonoBehaviour
{
    public GameObject username;

    public GameObject drop;
    public GameObject dropModel;

    private string Name;

    private int Dropper;
    private int DropperModel;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSfyVtiVtOOgpz8qxQqm0r--ulrj8u2B_tXldNNAQhvGmb3O0g/formResponse";

    IEnumerator Post(string name, int drop, int dropModel)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1755259562", name);
        form.AddField("entry.756974309", dropModel);
        form.AddField("entry.558954491", drop);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }

    public void Send()
    {
        Name = username.GetComponent<TMP_InputField>().text;

        Dropper = drop.GetComponent<Dropdown>().value;
        DropperModel = drop.GetComponent<Dropdown>().value;

        StartCoroutine(Post(Name, Dropper, DropperModel));

    }

}
