using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IconView : MonoBehaviour
{
    [SerializeField] private ComputerIconsSO _typefile;

    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _text;

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
        _text.text = _typefile.name;
    }
}
