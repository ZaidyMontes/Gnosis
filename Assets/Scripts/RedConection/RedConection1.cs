using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedConection1 : MonoBehaviour
{
    public int id1;
    public RedBridge redBridge;



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
        if (id1 == 4 && redBridge.id2 == 4)
        {
            id1 = 44;
            redBridge.id2 = 44;

            print("Soy Rojo, conection start");
        }



    }
}
