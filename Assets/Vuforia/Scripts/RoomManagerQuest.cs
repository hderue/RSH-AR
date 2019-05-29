using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RoomManagerQuest : MonoBehaviour
{

    public RoomObject[] rooms;
    public bool[] roomCompleted;
    public bool Complete = false;
    public GameObject DonePanel;

    // Start is called before the first frame update
    void Start()
    {
       roomCompleted = new bool[rooms.Length];
       
    }

    private void Update()
    {
        

      if(roomCompleted[0] == true && roomCompleted[1] == true && roomCompleted[2] == true && roomCompleted[3] == true  && !Complete)
        {
            Complete = true;
            Debug.Log("Done");
            DonePanel.SetActive(true);

        }

        return;
    }



}
