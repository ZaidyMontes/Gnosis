using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conection1 : MonoBehaviour
{
    public int id1;
    public Bridge bridge;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (id1 == 1 && bridge.id2 == 1 )
        {
            id1 = 11;
            bridge.id2 = 11;

            print("Soy Amarillo, conection start");
        }
       


    }
   
}
