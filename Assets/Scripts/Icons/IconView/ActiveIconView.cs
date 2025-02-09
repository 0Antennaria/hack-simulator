using Unity.Android.Gradle.Manifest;
using UnityEngine;
using System;

public class ActiveIconView : MonoBehaviour
{
    [SerializeField] static private IconView _currentIcon;

    public IconView CurrentIcon => _currentIcon;

    public void ChangeActiveIcon(IconView icon)
    {
        if (_currentIcon != null)
        {
            _currentIcon.ChangeActivePanelWhenClick(false);
        }

        _currentIcon = icon;
        _currentIcon.ChangeActivePanelWhenClick(true);
    }

    public void ResetActive()
    {
        if (_currentIcon != null)
        {
            _currentIcon.ChangeActivePanelWhenClick(false);
            _currentIcon = null;
        }
    }
}
