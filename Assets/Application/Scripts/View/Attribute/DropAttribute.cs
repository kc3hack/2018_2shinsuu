using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UniRx;


public class DropAttribute : MonoBehaviour, IDropHandler{
    [System.NonSerialized]
    public bool isPointerOvar = false;
    public Subject<GameObject> dropEventSubject = new Subject<GameObject>();


    public void OnDrop(PointerEventData data){
        if (data.pointerDrag != null){
            dropEventSubject.OnNext(data.pointerDrag);
        }
    }


}
