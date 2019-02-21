using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UniRx;

public class FlickAttrubute : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    private Vector3 acceleration;
    private Vector3 preAcceleration;
    private float lastDeltaTime = 0f;
    public Subject<Vector3> flickEventSubject = new Subject<Vector3>();

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
        flickEventSubject.OnNext(preAcceleration);
    }

}
