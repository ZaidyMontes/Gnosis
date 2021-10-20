using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenConect1 : MonoBehaviour
{
    public int id1;
    public GreenBridge greenBridge;



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
        if (id1 == 3 && greenBridge.id2 == 3)
        {
            id1 = 33;
            greenBridge.id2 = 33;

            print("Soy Verde, conection start");
        }



    }
}
