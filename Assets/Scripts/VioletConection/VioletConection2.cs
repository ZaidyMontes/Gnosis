using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VioletConection2 : MonoBehaviour
{
    public int id3;
    public GameObject parte2Violeta;
    public VioletBridge violetBridge;
    public VioletConection1 violetConection1;
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

        if (violetConection1.id1 == 22 && violetBridge.id2 == 22 && id3 == 2)
        {
            Instantiate(parte2Violeta);
            instancia2++;
            if (instancia2 >= 1)
            {
                Destroy(gameObject);
            }
        }

    }
}
