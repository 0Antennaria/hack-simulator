using UnityEngine;
using UnityEngine.EventSystems;

public class TrackingActiveIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,
    IPointerClickHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private ActiveIconView _activeIconView;
    [SerializeField] private ActiveIcon _activeIcon;

    private IconView _iconView;
    private InventoryIcon _icon;

    private void Awake()
    {
        _iconView = GetComponent<IconView>();
        _icon = GetComponent<InventoryIcon>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _activeIcon.ChangeActiveIcon(_icon);
        _activeIconView.ChangeActiveIcon(_iconView);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _iconView.ChangeActivePanelWhenHover(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _iconView.ChangeActivePanelWhenHover(false);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _activeIconView.ResetActive();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _activeIconView.ChangeActiveIcon(_iconView);
    }
}
