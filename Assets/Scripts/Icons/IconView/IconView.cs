using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IconView : MonoBehaviour
{
    public ComputerIconsSO _typefile;
    public TMP_Text _text;
    public GameObject _inputField;

    [SerializeField] private Image _icon;

    [SerializeField] private GameObject _hoverPanel;
    [SerializeField] private GameObject _clickPanel;

    public void ChangeActivePanelWhenHover(bool active)
    {
        _hoverPanel.SetActive(active);
    }

    public void ChangeActivePanelWhenClick(bool active)
    {
        _clickPanel.SetActive(active);
    }

    private void Awake()
    {
        _icon.sprite = _typefile.ImageIcon;
        _text.text = _typefile.Name;
    }
}
