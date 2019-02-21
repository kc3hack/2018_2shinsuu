using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragAttribute : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [System.NonSerialized]
    public RectTransform myRect;
    
    private Transform canvasTran;
    private GameObject draggingObject;
    
    [System.NonSerialized]
    public bool isDraging = false;

    // Use this for initialization
    void Start(){
        myRect = GetComponent<RectTransform>();
    }
    
    void Awake()
    {
        canvasTran = transform.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        CreateDragObject();
        draggingObject.transform.position = eventData.position;
        isDraging = true;
    }


    public void OnDrag(PointerEventData eventData){
        //myRect.position += new Vector3(eventData.delta.x, eventData.delta.y, 0f);
        draggingObject.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData){
        gameObject.GetComponent<Image>().color = Vector4.one;
        Destroy(draggingObject);
        isDraging = false;
    }
    
    // ドラッグオブジェクト作成
    private void CreateDragObject()
    {
        draggingObject = new GameObject("Dragging Object");
        draggingObject.transform.SetParent(canvasTran);
        draggingObject.transform.SetAsLastSibling();
        draggingObject.transform.localScale = Vector3.one;

        // レイキャストがブロックされないように
        CanvasGroup canvasGroup = draggingObject.AddComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = false;

        Image draggingImage = draggingObject.AddComponent<Image>();
        Image sourceImage = GetComponent<Image>();

        draggingImage.sprite = sourceImage.sprite;
        draggingImage.rectTransform.sizeDelta = sourceImage.rectTransform.sizeDelta;
        draggingImage.color = sourceImage.color;
        draggingImage.material = sourceImage.material;

        gameObject.GetComponent<Image>().color = Vector4.one * 0.6f;
    }
}
