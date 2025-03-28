using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class InventoryIcon : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    [SerializeField] private ActiveIconView _typefile;

    private CreateWorkWindow _createWorkPanel;
    private CreateParametrPnael _parametrsPanel;
    private PlayerInput _playerInput;
    private CreateOptionsIconPanel _iconPanel;
    private SaveText _informationAboutPanel;
    private SaveName _saveName;

    public SaveName SaveName => _saveName;

    public event UnityAction<GameObject> AddIconForTaskBar;


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

        _informationAboutPanel = GetComponent<SaveText>();
        _saveName = GetComponent<SaveName>();
    }

    private void CreateWorkWindow()
    {
        GameObject panel = _createWorkPanel.CreateAndReturn(_typefile.CurrentIcon._typefile.OpeningApplication);
        AddIconForTaskBar?.Invoke(panel);

        if (panel.TryGetComponent<AddInformation>(out AddInformation workpanel))
        {
            workpanel.AddInfoWhenCreate(_informationAboutPanel);
            workpanel.LoadInfo();
        }

        if (panel.TryGetComponent<LoadNamePanel>(out LoadNamePanel loadpanel))
        {
            loadpanel.LoadName(_saveName.Name);
        }

        if (this.TryGetComponent<BlockOpen>(out BlockOpen blockOpen))
        {
            panel.SetActive(false);
            blockOpen.OnSavePanel(panel);
            blockOpen.OnBlockPanel();
        }
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
