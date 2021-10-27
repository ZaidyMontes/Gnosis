using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDriver : MonoBehaviour
{
    public int id1;
    public int id2;
    public int id3;
    public int id4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Id1()
    {
        
        if(id1 == 1 && id2 == 0 && id3 == 0 && id4 == 0)
        {
            id1 = 1;
            print("id1");
        }
    
        
    }
    public void Id2()
    {
        if (id1 == 0 && id2 == 2 && id3 == 0 && id4 == 0)
        {
            id2 = 2;
        print("id2");

        }
       
            
    }
    public void Id3()
    {
        if (id1 == 3 && id2 == 0 && id3 == 0 && id4 == 0)
        {
            id2 = 3;
            print("id3");

        }
        
    }
    public void Id4()
    {
        if (id1 == 4 && id2 == 0 && id3 == 0 && id4 == 0)
        {
            id2 = 4;
            print("id4");

        }
       
    }


}
