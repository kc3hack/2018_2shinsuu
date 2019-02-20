using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DropAttribute : MonoBehaviour, IDropHandler{
    [System.NonSerialized]
    public bool isPointerOvar = false;
    public UnityEvent dropEvent;

    public void OnDrop(PointerEventData data){
        if (data.pointerDrag != null)
        {
            if(dropEvent != null)dropEvent.Invoke();
            DragAttribute dragAttr = data.pointerDrag.GetComponent<DragAttribute>();
            if (dragAttr != null && dragAttr.DropedEvent != null) dragAttr.DropedEvent.Invoke();
        }
    }


}
