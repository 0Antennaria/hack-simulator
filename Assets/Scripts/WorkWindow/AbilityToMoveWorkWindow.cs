using UnityEngine;
using UnityEngine.UI;

public class AbilityToMoveWorkWindow : MonoBehaviour
{
    [SerializeField] private Image _icon;

    public void DestroyRaycastTarget()
    {
        _icon.raycastTarget = false;
    }

    public void TurnRaycastTarget()
    {
        _icon.raycastTarget = true;
    }

    public void ChangeColor(byte red, byte green, byte blue, byte alpha)
    {
        _icon.color = new Color32(red, green, blue, alpha);
    }
}
