using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomInstantiate : MonoBehaviour
{
    public GameObject roomWindow;

    public void OpenRoomwindow()
    {
        if (roomWindow != null)
        {
            bool isActive = roomWindow.activeSelf;
            roomWindow.SetActive(!isActive);
        }
    }
}
