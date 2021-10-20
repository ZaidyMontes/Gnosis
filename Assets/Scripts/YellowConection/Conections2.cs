using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conections2 : MonoBehaviour
{
    public int id3;
    public GameObject parte2Amarilla;
    public Bridge bridge;
    public Conection1 conection1;
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
        
        if(conection1.id1 == 11 && bridge.id2 == 11 && id3 ==1)
        {
            Instantiate(parte2Amarilla);
            instancia2++;
            if (instancia2 >= 1)
            {
                Destroy(gameObject);
            }
        }

    }


        
}
