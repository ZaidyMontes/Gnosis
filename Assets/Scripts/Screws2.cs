using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Screws2 : MonoBehaviour
{

    public int id3;
    public ScrewDriver screwDriver;
    public GameObject Ready;
    public int inst;
    
   
   

    public void Press()

    {
        
       

       if(id3 == 3 && screwDriver.id3 == 3)
        {
            
            Destroy(gameObject);
            Instantiate(Ready);
            inst ++;
            id3 = 0;
        }
        else if (inst >= 1)
        {
            id3 = 0;
        }


    }
}
