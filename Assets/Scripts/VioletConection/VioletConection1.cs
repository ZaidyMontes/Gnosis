using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VioletConection1 : MonoBehaviour
{
    public int id1;
    public VioletBridge violetBridge;



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
        if (id1 == 2 && violetBridge.id2 == 2)
        {
            id1 = 22;
            violetBridge.id2 = 22;

            print("Soy Violeta, conection start");
        }



    }
}
