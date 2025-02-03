using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreateParametrPnael : MonoBehaviour
{
    [SerializeField] private GameObject _sizeMenu;
    [SerializeField] private GameObject _parametrsMenu;

    [SerializeField] OpeningParameters _openPanel;

    private PlayerInput _playerInput;
    private float _sizePanelX;
    private float _sizePanelY;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        RectTransform sizeParametrsPanel = (RectTransform)_sizeMenu.transform;
        _sizePanelX = (sizeParametrsPanel.rect.width / 2);
        _sizePanelY = (sizeParametrsPanel.rect.height / 2);

        _playerInput.User.RightClick.performed += ctx => CheckLocationOpeningPanel();
    }

    private void CheckLocationOpeningPanel()
    {
        _openPanel.CheckLocationOpeningPanel(_sizePanelX, _sizePanelY, _sizeMenu, _parametrsMenu);
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void OffPanel()
    {
        _playerInput.Disable();
    }

    public void OnPanel()
    {
        _playerInput.Enable();
    }
}
