using Unity.VisualScripting;
using UnityEngine;

public class ActiveIcon : MonoBehaviour
{
    private InventoryIcon _currentIcon;

    public InventoryIcon CurrentIcon => _currentIcon;

    public void ChangeActiveIcon(InventoryIcon icon)
    {
        _currentIcon = icon;
    }
}
