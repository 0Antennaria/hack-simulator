using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    protected Transform StartingPosition;
    [SerializeField] protected GameObject Panel;

    public virtual void OnBeginDrag(PointerEventData eventData)
    {
        StartingPosition = transform.parent;
        Panel.transform.SetParent(transform.root);
        Panel.transform.SetAsLastSibling();
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
        Panel.transform.position = Input.mousePosition;
    }

    public virtual void OnEndDrag(PointerEventData eventData)
    {
        Panel.transform.SetParent(StartingPosition);
    }
}
