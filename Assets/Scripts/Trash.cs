using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Trash : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public DragBateryLow bateryID;
    private int ready;
    public bool red;

    private void Start()
    {
        
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
        ready++;
        print(ready);
        if (ready == 1)
        {
            red = true;
        }
    }
}
