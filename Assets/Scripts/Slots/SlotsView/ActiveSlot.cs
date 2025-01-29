using UnityEngine;

public class ActiveSlot : MonoBehaviour
{
    private InventorySlot _currentSlot;

    public InventorySlot CurrentSlot => _currentSlot;

    public void ChangeActiveSlot(InventorySlot slot)
    {
        _currentSlot = slot;
    }
}
