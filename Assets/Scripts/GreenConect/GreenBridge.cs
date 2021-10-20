using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBridge : MonoBehaviour
{
    public GreenConect1 greenConect1;
    public int id2;
    public GameObject parte1Green;
    public int instancia1;

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

        if (greenConect1.id1 == 33 && id2 == 33)
        {

            Instantiate(parte1Green);
            instancia1++;
            if (instancia1 >= 1)
            {
                Destroy(gameObject);
            }
        }

        else
        {
            id2 = 3;

        }



    }
}
