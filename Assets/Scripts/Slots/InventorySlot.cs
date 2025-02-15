using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TrackingActiveSlot))]
public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggableItemIcon draggableItem = dropped.GetComponent<DraggableItemIcon>();
        if (draggableItem is DraggableItemIcon)
            draggableItem.ChangeSlot(transform);

    }
}
