using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapInitiate : MonoBehaviour
{

    public GameObject Minimap;

    public void OpenMinimap()
    {
        if(Minimap != null)
        {
            bool isActive = Minimap.activeSelf;
            Minimap.SetActive(!isActive);
        }
    }
}
