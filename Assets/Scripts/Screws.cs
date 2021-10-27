using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Screws : MonoBehaviour
{

    public int id1;
    public ScrewDriver screwDriver;
    public GameObject Ready;
    public int inst;
    
   
   

    public void Press()

    {
        
       

       if(id1 == 1 && screwDriver.id1 == 1)
        {
            
            Destroy(gameObject);
            Instantiate(Ready);
            inst ++;
            
        }
       else if(inst>= 1)
        {
            id1 = 0;
        }
        

    }
}
