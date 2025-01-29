using Unity.Android.Gradle.Manifest;
using UnityEngine;
using System;

public class ActiveIconView : MonoBehaviour
{
    [SerializeField] private IconView _currentIcon;

    public void Update()
    {
        if (_currentIcon != null)
            Debug.Log("wwww" + _currentIcon.name);

    }
    public void ChangeActiveIcon(IconView icon)
    {
        if (_currentIcon != null)
        {
            _currentIcon.ChangeActivePanelWhenClick(false);
        }

        _currentIcon = icon;
        _currentIcon.ChangeActivePanelWhenClick(true);
        Debug.Log(_currentIcon == null);

    }

    public void ResetActive()
    {
        Debug.Log(_currentIcon);

        if (_currentIcon != null)
        {
            _currentIcon.ChangeActivePanelWhenClick(false);
        }
    }
}
