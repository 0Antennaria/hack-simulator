using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class DraggableItemWorkWindow : DraggableItem
{
    [SerializeField] private RectTransform _panel;
    [SerializeField] private AbilityToMoveWorkWindow _image;

    private Vector2 _localMousePosition;

    public override void OnBeginDrag(PointerEventData eventData)
    {
        _localMousePosition = _panel.InverseTransformPoint(Input.mousePosition);
        base.OnBeginDrag(eventData);
        _image.ChangeColor(21, 21, 21, 255);

    }

    public override void OnDrag(PointerEventData eventData)
    {
        Panel.transform.position = new Vector3
            (Input.mousePosition.x - _localMousePosition.x, Input.mousePosition.y - _localMousePosition.y, 0);
        _image.ChangeColor(21, 21, 21, 70);

    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        _image.ChangeColor(21, 21, 21, 255);
    }

    public void ChangeSlot(Transform transform)
    {
        StartingPosition = transform.transform;
    }
}
