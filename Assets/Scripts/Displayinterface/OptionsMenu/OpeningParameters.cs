using UnityEngine;
using UnityEngine.UIElements;

public class OpeningParameters : MonoBehaviour
{
    [SerializeField] private GameObject _sizeMenu;
    [SerializeField] private GameObject _parametrsMenu;

    private PlayerInput _playerInput;
    private MouseLocationTracking _mouseLocation;

    private float _sizePanelX;
    private float _sizePanelY;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _mouseLocation = GetComponent<MouseLocationTracking>();

        RectTransform sizeParametrsPanel = (RectTransform)_sizeMenu.transform;
        _sizePanelX = (sizeParametrsPanel.rect.width / 2);
        _sizePanelY = (sizeParametrsPanel.rect.height / 2);

        _playerInput.User.RightClick.performed += ctx => CheckLocationOpeningPanel();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void CheckLocationOpeningPanel()
    {
        float postitionX = _mouseLocation.PositionMouse.x;
        float postitionY = _mouseLocation.PositionMouse.y;

        if (postitionX < 0 && postitionY < 0)
            ShowOptionsMenu(-_sizePanelX, -_sizePanelY);

        if (postitionX > 0 && postitionY < 0)
            ShowOptionsMenu(_sizePanelX, -_sizePanelY);

        if (postitionX < 0 && postitionY > 0)
            ShowOptionsMenu(-_sizePanelX, _sizePanelY);

        if (postitionX > 0 && postitionY > 0)
            ShowOptionsMenu(_sizePanelX, _sizePanelY);
    }

    private void ShowOptionsMenu(float positionX, float positionY)
    {
        _sizeMenu.transform.position = new Vector3
        (Input.mousePosition.x - positionX, Input.mousePosition.y - positionY, 0);

        _parametrsMenu.SetActive(true);
    }
}
