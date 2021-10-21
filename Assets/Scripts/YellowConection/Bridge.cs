using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public Conection1 conection1;
    public int id2;
    public GameObject parte1Amarilla;
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

        if (conection1.id1 == 11 && id2 == 11)
        {

            Instantiate(parte1Amarilla);
            instancia1++;
            if (instancia1 >= 1)
            {
                Destroy(gameObject);
            }
        }

        else
        {
            id2 = 1;

        }



    }
}
