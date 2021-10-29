using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Screws : MonoBehaviour
{

    public int id1;
    public ScrewDriverLine screwDriverLine;
    public GameObject ints;
    
   

    private void Start()
    {
        
    }


    public void Press()

    {
        

       if(id1 == 1 && screwDriverLine.id == 1)
        {

            screwDriverLine.Count();
            Destroy(gameObject);
            
            
        }

       

    }
}
