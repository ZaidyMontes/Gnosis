using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Screws3 : MonoBehaviour
{

    public int id4;
    public ScrewDriver screwDriver;
    public GameObject Ready;
    public int inst;
    
   
   

    public void Press()

    {
        
       

       if(id4 == 4 && screwDriver.id4 == 4)
        {
            
            Destroy(gameObject);
            Instantiate(Ready);
            inst ++;
            
        }
        else if (inst >= 1)
        {
            id4 = 0;
        }



    }
}
