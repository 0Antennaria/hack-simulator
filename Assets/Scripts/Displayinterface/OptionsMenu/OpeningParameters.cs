using UnityEngine;
using UnityEngine.UIElements;

public class OpeningParameters : MonoBehaviour
{
    [SerializeField] private MouseLocationTracking _mouseLocation;

    private void Awake()
    {
        _mouseLocation = GetComponent<MouseLocationTracking>();
    }

    public void CheckLocationOpeningPanel(float _sizePanelX, float _sizePanelY, GameObject _sizeMenu, GameObject _parametrsMenu)
    {
        float postitionX = _mouseLocation.PositionMouse.x;
        float postitionY = _mouseLocation.PositionMouse.y;

        if (postitionX < 0 && postitionY < 0)
            ShowOptionsMenu(-_sizePanelX, -_sizePanelY, _sizeMenu, _parametrsMenu);

        if (postitionX > 0 && postitionY < 0)
            ShowOptionsMenu(_sizePanelX, -_sizePanelY, _sizeMenu, _parametrsMenu);

        if (postitionX < 0 && postitionY > 0)
            ShowOptionsMenu(-_sizePanelX, _sizePanelY, _sizeMenu, _parametrsMenu);

        if (postitionX > 0 && postitionY > 0)
            ShowOptionsMenu(_sizePanelX, _sizePanelY, _sizeMenu, _parametrsMenu);
    }

    private void ShowOptionsMenu(float positionX, float positionY, GameObject _sizeMenu, GameObject _parametrsMenu)
    {
        _sizeMenu.transform.position = new Vector3
        (Input.mousePosition.x - positionX, Input.mousePosition.y - positionY, 0);

        _parametrsMenu.SetActive(true);
    }
}
