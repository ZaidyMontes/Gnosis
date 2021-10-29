using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public DragHandler bateryID;
    private int ready;
    public bool green;

    
    

    private void Start()
    {
        
    }
    
    
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");

        if (!item && bateryID.id == 2)
        {
            item = DragHandler.objBeingDraged;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;

            
            Complete();

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

    public void Complete()
    {
        ready++;
        print(ready);
        if (ready == 1)
        {
            green = true;
        }
    }
   
}
