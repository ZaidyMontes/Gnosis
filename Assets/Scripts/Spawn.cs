using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawn : MonoBehaviour
{
    public GameObject parteAmarilla;
    private bool yellow;
    private bool conection;
    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //YELLOW
    public void Yellow1()
    {
        yellow = true;
    }
    public void Yellow2()
    {
        conection = true;
       /* if(yellow == true)
        {
            source.Play(clip1);
        }

        else
        {
            source.Play()
        }*/
    }
    
    public void Conection()
    {
        if(yellow == true && conection == true )
        Instantiate(parteAmarilla, transform.position, transform.rotation);
    }

    //RED


    //VIOLET

    //VERDE

    
}
