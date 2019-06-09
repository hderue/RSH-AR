using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendToGoogle : MonoBehaviour
{
    public GameObject username;
    public GameObject email;
    public GameObject phone;
    public GameObject drop;

    private string Name;
    private string Email;
    private string Phone;
    private int Dropper;
     
    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSfyVtiVtOOgpz8qxQqm0r--ulrj8u2B_tXldNNAQhvGmb3O0g/formResponse";

    IEnumerator Post(string name, string email, string phone, int drop)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1755259562", name);
        form.AddField("entry.1200349711", email);
        form.AddField("entry.472336746", phone);
        form.AddField("entry.558954491", drop);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
        
    }

    public void Send()
    {
        Name = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Phone = phone.GetComponent<InputField>().text;
        Dropper = drop.GetComponent<Dropdown>().value;


        StartCoroutine(Post(Name, Email, Phone, Dropper));

    }

}
