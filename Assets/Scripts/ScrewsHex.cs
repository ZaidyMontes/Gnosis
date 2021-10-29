using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrewsHex : MonoBehaviour
{

    public int id2;
    public ScrewDriverLine screwDriver2;


    private void Start()
    {

    }


    public void Press()

    {


        if (id2 == 2 && screwDriver2.id == 2 && screwDriver2.id == 2)
        {
            screwDriver2.Count();
            Destroy(gameObject);


        }



    }

}
