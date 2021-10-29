using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrewDriverLine : MonoBehaviour, IDragHandler
{

    public int id;
    public int count;
    public DragCover cover;
    
    // Start is called before the first frame update
    void Start()
    {
        id = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ID1()
    {

        id = 1;
        if (id == 1)
        {
         
            print("id1");
            
            
        }


    }

    public void ID2()
    {

        id = 2;
        if (id == 2)
        {
           

            print("id2");


        }


    }
    public void ID3()
    {

        id = 3;
        if (id == 3)
        {


            print("id3");


        }


    }

    public void ID4()
    {

        id = 4;
        if (id == 4)
        {


            print("id4");


        }


    }
    public void OnDrag(PointerEventData eventData)
    {




    }

    public void Count()
    {
        count++;
        if(count == 4)
        {
            count = 4;
        }
    }

}

