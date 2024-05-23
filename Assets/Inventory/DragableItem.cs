using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    public int points;
    public scoreMangaer scoreMan;
    public float scaleX;
    public float scaleY;

    //private int numberOfDrops = 0;

    [HideInInspector]  public Transform parentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        //transform.localScale = new Vector3(scaleX, scaleY, 1f);
        image.raycastTarget = true;
        
        if (transform.parent.tag == "Top")
        {
            scoreMan.AddPoint(points);
            transform.localScale = new Vector3(scaleX, scaleY, 1f);
        }

        if (transform.parent.tag == "Bottom")
        {
            scoreMan.AddPoint(points);
            transform.localScale = new Vector3(scaleX, scaleY, 1f);
        }

        if (transform.parent.tag == "Slot")
        {
            //numberOfDrops = 0;
            scoreMan.RemovePoint(points);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
