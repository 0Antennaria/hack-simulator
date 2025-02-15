using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(TrackingActiveIcon))]
[RequireComponent(typeof(AbilityToMoveIcon))]
public class DraggableItemIcon : DraggableItem, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private AbilityToMoveIcon _image;

    private void Awake()
    {
        _image = GetComponent<AbilityToMoveIcon>();
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        _image.DestroyRaycastTarget();
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        _image.ChangeColor(255, 255, 255, 70);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        _image.TurnRaycastTarget();
        _image.ChangeColor(255, 255, 255, 255);
    }

    public void ChangeSlot(Transform transform)
    {
        StartingPosition = transform.transform;
    }
}
