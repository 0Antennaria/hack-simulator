using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventoryIcon : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    private PlayerInput _playerInput;
    private TrackingActiveIcon _iconView;
    [SerializeField] private CreateOptionsIconPanel _iconPanel;
    [SerializeField] private CreateParametrPnael _parametrsPanel;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _iconView = GetComponent<TrackingActiveIcon>();

        _playerInput.Icon.RightClick.performed += ctx => CreateIconMenu();

    }

    private void Start()
    {
        _iconPanel = FindAnyObjectByType<CreateOptionsIconPanel>();
        _parametrsPanel = FindAnyObjectByType<CreateParametrPnael>();

    }

    private void CreateIconMenu()
    {
        _iconPanel.OpenParametrs();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _playerInput.Enable();
        _parametrsPanel.OffPanel();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _playerInput.Disable();
        _parametrsPanel.OnPanel();
    }
}
