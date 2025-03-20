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

    public void ChangeAlpha(float alpha)
    {
        _icon.color = new Color(_icon.color.r, _icon.color.g, _icon.color.b, alpha);
    }
}
