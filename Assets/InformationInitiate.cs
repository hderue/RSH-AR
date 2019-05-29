using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationInitiate : MonoBehaviour
{
    public GameObject InfoWindow;

    public void OpenInforwindow()
    {
        if (InfoWindow != null)
        {
            bool isActive = InfoWindow.activeSelf;
            InfoWindow.SetActive(!isActive);
        }
    }
}
