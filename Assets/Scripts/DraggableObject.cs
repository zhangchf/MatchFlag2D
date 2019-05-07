using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Action StartDragAction;
    public Action EndDragAction;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        if (StartDragAction != null)
        {
            StartDragAction.Invoke();
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        if (EndDragAction != null)
        {
            EndDragAction.Invoke();
        }
    }
}
