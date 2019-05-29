using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomObject : MonoBehaviour
{

    public int roomNumber;
    public RoomManagerQuest RMQ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartRoom()
    {

    }

    public void EndRoom()
    {
        RMQ.roomCompleted[roomNumber] = true;
        
    }
}
