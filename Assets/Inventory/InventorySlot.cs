using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public DragableItem dragableItem;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DragableItem dragableItem = dropped.GetComponent<DragableItem>();
          //  dragableItem.scaleX = 1;
         //   dragableItem.scaleY = 1;
            dragableItem.parentAfterDrag = transform;
            
        }
        
    }
}
