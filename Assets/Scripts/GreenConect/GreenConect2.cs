using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenConect2 : MonoBehaviour
{
    public int id3;
    public GameObject parte2Green;
    public GreenBridge greenBridge;
    public GreenConect1 greenConect1;
    public int instancia2;



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

        if (greenConect1.id1 == 33 && greenBridge.id2 == 33 && id3 == 3)
        {
            Instantiate(parte2Green);
            instancia2++;
            if (instancia2 >= 1)
            {
                Destroy(gameObject);
            }
        }

    }
}
