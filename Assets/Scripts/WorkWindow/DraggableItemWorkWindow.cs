using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItemWorkWindow : DraggableItem
{
    [SerializeField] private RectTransform _panel;
    [SerializeField] private AbilityToMoveWorkWindow _image;

    private Vector2 _localMousePosition;

    public override void OnBeginDrag(PointerEventData eventData)
    {
        _localMousePosition = _panel.InverseTransformPoint(Input.mousePosition);
        base.OnBeginDrag(eventData);
        _image.ChangeAlpha(1);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Panel.transform.position = new Vector3
            (Input.mousePosition.x - _localMousePosition.x, Input.mousePosition.y - _localMousePosition.y, 0);
        _image.ChangeAlpha(0.7f);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        _image.ChangeAlpha(1);
    }

    public void ChangeSlot(Transform transform)
    {
        StartingPosition = transform.transform;
    }
}
