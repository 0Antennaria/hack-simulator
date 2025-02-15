using UnityEngine;

public class CreateOptionsIconPanel : MonoBehaviour
{
    [SerializeField] private GameObject _sizeMenu;
    [SerializeField] private GameObject _parametrsMenu;

    [SerializeField] OpeningParameters _openPanel;

    private float _sizePanelX;
    private float _sizePanelY;

    private void Awake()
    {
        RectTransform sizeParametrsPanel = (RectTransform)_sizeMenu.transform;
        _sizePanelX = (sizeParametrsPanel.rect.width / 2);
        _sizePanelY = (sizeParametrsPanel.rect.height / 2);
    }

    public void OpenParametrs()
    {
        _openPanel.CheckLocationOpeningPanel(_sizePanelX, _sizePanelY, _sizeMenu, _parametrsMenu);
    }
}
