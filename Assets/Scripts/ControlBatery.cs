using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBatery : MonoBehaviour
{
    public Trash low;
    public DropSlot hight1;
    public SlotBatery2 hight2;
    public GameObject boton;
    private int inst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {

        if (low.red == true && hight1.green == true && hight2.green == true)
        {
            Instanciar();
        }
    }
    public void Instanciar()
    {
        Instantiate(boton);
        inst++;
        if (inst > 1)
        {
            Destroy(gameObject);
        }
    }
}
