using UnityEngine;
using UnityEngine.UI;

public class AbilityToMoveIcon : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private GameObject _hoverPanel;
    [SerializeField] private GameObject _clickPanel;

    public void DestroyRaycastTarget()
    {
        _icon.raycastTarget = false;
        _hoverPanel.SetActive(false);
        _clickPanel.SetActive(false);
    }

    public void TurnRaycastTarget()
    {
        _icon.raycastTarget = true;
        _hoverPanel.SetActive(true);
        _clickPanel.SetActive(true);
    }

    public void ChangeColor(byte red, byte green, byte blue, byte alpha)
    {
        _icon.color = new Color32
            (red, green, blue, alpha);
    }

}
