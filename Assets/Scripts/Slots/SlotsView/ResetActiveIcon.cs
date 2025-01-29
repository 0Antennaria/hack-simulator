using UnityEngine;
using UnityEngine.EventSystems;

public class ResetActiveIcon : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private ActiveIconView _activeIcon;

    public void OnPointerClick(PointerEventData eventData)
    {
        _activeIcon.ResetActive();
    }
}
