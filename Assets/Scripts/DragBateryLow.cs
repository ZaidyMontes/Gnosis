using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragBateryLow : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject objBeingDraged;
    public int id = 1;

    private Vector3 startPosition;
    private Transform startParent;

    private Transform DragParent;

    private void Start()
    {
        
        DragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }

    #region DragFunctions

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        objBeingDraged = gameObject;

        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(DragParent);



    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        objBeingDraged = null;


        if (transform.parent == DragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }

    #endregion

    private void Update()
    {

    }
}
