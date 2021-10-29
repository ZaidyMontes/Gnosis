using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrewsXN : MonoBehaviour
{

    public int id3;
    public ScrewDriverLine screwDriverLine;


    private void Start()
    {

    }


    public void Press()

    {


        if (id3 == 3 && screwDriverLine.id == 3)
        {
            screwDriverLine.Count();
            Destroy(gameObject);


        }



    }




}
