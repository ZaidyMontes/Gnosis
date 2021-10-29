using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrewsXB : MonoBehaviour
{

    public int id4;
    public ScrewDriverLine screwDriverLine;


    private void Start()
    {

    }


    public void Press()

    {


        if (id4 == 4 && screwDriverLine.id == 4)
        {
            screwDriverLine.Count();
            Destroy(gameObject);


        }



    }



}
