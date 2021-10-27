using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Screws1 : MonoBehaviour
{

    public int id2;
    public ScrewDriver screwDriver;
    public GameObject Ready;
    public int inst;
    
   
   

    public void Press()

    {
        
       

       if(id2 == 2 && screwDriver.id2 == 2)
        {
            
            Destroy(gameObject);
            Instantiate(Ready);
            inst ++;
            
        }
       else if (inst >= 1)
        {
            id2 = 0;
        }
       

    }
}
