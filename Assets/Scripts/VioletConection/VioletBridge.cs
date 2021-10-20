using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VioletBridge : MonoBehaviour
{
    public VioletConection1 violetConection1;
    public int id2;
    public GameObject parte1Violeta;
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

        if (violetConection1.id1 == 22 && id2 == 22)
        {

            Instantiate(parte1Violeta);
            instancia1++;
            if (instancia1 >= 1)
            {
                Destroy(gameObject);
            }
        }

        else
        {
            id2 = 2;

        }



    }
}
