using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roommanager : MonoBehaviour
{

    public List<GameObject> rooms;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableOther(int id)
    {
        
        for(int i =0;i<rooms.Count;i++)
        {
            if(i == id)
            {
                
                rooms[id].SetActive(true);

        
            }
            else
            {
                rooms[i].SetActive(false);
                
               
            }
            
        }

    }
}
