using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AddInformation : MonoBehaviour
{
    [SerializeField] private SaveText _icon;
    [SerializeField] private TMP_InputField _text;

    public void AddInfo()
    {
        _icon.OnSaveText(_text);
    }

    public void AddInfoWhenCreate(SaveText icon)
    {
        if(_icon == null)
            _icon = icon;
    }
    public void LoadInfo()
    {
        _text.text = _icon.Text;
    }
}
