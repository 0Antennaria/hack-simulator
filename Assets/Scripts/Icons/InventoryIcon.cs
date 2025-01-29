using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryIcon : MonoBehaviour, IPointerClickHandler
{
    private PlayerInput _playerInput;
    [SerializeField] private ActiveIcon _activeIcon;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void CreateIconMenu()
    {
        if (_activeIcon == this)
            Debug.Log("Ãאפ-דאפ");
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _playerInput.User.RightOnIcon.performed += ctx => CreateIconMenu();
    }
}
