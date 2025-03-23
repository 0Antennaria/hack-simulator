using UnityEngine;

public class ChangeNameIcon : MonoBehaviour
{
    [SerializeField] private IconView _iconView;
    [SerializeField] private SaveName _name;

    public void OnText(string text)
    {
        _iconView._text.text = text;
        _name.LoadName(_iconView._text.text);
    }
}
