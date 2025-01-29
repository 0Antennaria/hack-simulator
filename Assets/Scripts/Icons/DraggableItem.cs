using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(TrackingActiveIcon))]
[RequireComponent(typeof(AbilityToMoveIcon))]
public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform _startingPosition;
    private AbilityToMoveIcon _image;

    private void Awake()
    {
        _image = GetComponent<AbilityToMoveIcon>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _startingPosition = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        _image.DestroyRaycastTarget();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        _image.ChangeColor(255, 255, 255, 70);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(_startingPosition);
        _image.TurnRaycastTarget();
        _image.ChangeColor(255, 255, 255, 255);
    }

    public void ChangeSlot(Transform transform)
    {
        _startingPosition = transform.transform;
    }
}
