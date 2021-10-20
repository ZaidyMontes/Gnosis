using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedConection2 : MonoBehaviour
{
    public int id3;
    public GameObject parte2Red;
    public RedBridge redBridge;
    public RedConection1 redConection1;
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

        if (redConection1.id1 == 44 && redBridge.id2 == 44 && id3 == 4)
        {
            Instantiate(parte2Red);
            instancia2++;
            if (instancia2 >= 1)
            {
                Destroy(gameObject);
            }
        }

    }
}
