using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventoryIcon : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
   [SerializeField] private ActiveIconView _typefile;

    private CreateWorkWindow _createWorkPanel;
    private CreateParametrPnael _parametrsPanel;
    private PlayerInput _playerInput;
    private CreateOptionsIconPanel _iconPanel;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Icon.RightClick.performed += ctx => OpenIconMenu();
        _playerInput.Icon.DoubleClick.performed += ctx => CreateWorkWindow();
    }

    private void Start()
    {
        _iconPanel = FindAnyObjectByType<CreateOptionsIconPanel>();
        _parametrsPanel = FindAnyObjectByType<CreateParametrPnael>();
        _createWorkPanel = FindAnyObjectByType<CreateWorkWindow>();
    }

    private void CreateWorkWindow()
    {
        _createWorkPanel.Create(_typefile.CurrentIcon._typefile.OpeningApplication);
    }

    private void OpenIconMenu()
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
