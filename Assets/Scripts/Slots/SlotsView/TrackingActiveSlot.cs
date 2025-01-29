using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class TrackingActiveSlot : MonoBehaviour, IPointerEnterHandler
{
    private InventorySlot _currentSlot;
    [SerializeField] private ActiveSlot _activeSlot;

    private void Awake()
    {
        _currentSlot = GetComponent<InventorySlot>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _activeSlot.ChangeActiveSlot(_currentSlot);
    }
}
