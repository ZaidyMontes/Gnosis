using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    
    public GameObject task;
    bool playerClose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTaskActive() && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(task);
        }
    
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerClose = true;
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerClose = false;
        }
    }
    private bool IsTaskActive()
    {
        return playerClose && !GameObject.FindWithTag("Task");
    }
}


