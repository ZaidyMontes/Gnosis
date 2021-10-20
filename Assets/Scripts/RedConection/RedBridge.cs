using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBridge : MonoBehaviour
{
    public RedConection1 redConection1;
    public int id2;
    public GameObject parte1Red;
    private int instancia1;

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

        if (redConection1.id1 == 44 && id2 == 44)
        {

            Instantiate(parte1Red);
            instancia1++;
            if (instancia1 >= 1)
            {
                Destroy(gameObject);
            }
        }

        else
        {
            id2 = 4;

        }



    }
}
