using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragCover : MonoBehaviour, IDragHandler

{
    public ScrewDriverLine screwDriver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnDrag(PointerEventData eventData)
    {
        if(screwDriver.count == 4)
        {
            transform.position = Input.mousePosition;
        }
        
          
        
        
    }



}
