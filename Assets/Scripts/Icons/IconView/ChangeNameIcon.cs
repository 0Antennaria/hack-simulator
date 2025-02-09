using UnityEngine;
using TMPro;

public class ChangeNameIcon : MonoBehaviour
{
    [SerializeField] private IconView _iconView;

    public void OnText(string text)
    {
        _iconView._text.text = text;
    }
}
