using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlickAttrubute : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    private Vector3 acceleration;
    private Vector3 preAcceleration;


    public void OnBeginDrag(PointerEventData eventData)
    {

    }


    public void OnDrag(PointerEventData eventData)
    {
        var delta = new Vector3(eventData.delta.x, eventData.delta.y, 0f);
        preAcceleration = acceleration;
        acceleration = delta;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
    }

}
