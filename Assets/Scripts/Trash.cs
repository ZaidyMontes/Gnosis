using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Trash : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public DragBateryLow bateryID;
    public bool ready;

    private void Start()
    {
        ready = false;
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

        if (!item && bateryID.id == 1)
        {
            
            
             item = DragBateryLow.objBeingDraged;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;

            Complete1();
        }
    }

    private void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            Debug.Log("Remover");
            item = null;
        }
    }
    
    public void Complete1()
    {
        ready = true;
        print("Trash Complete");
    }
}
