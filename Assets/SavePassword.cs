using System;
using UnityEngine;

public class SavePassword : MonoBehaviour
{
    private string _password;
    private GameObject _panel;

    public string Password => _password;

    public void GetPassword(string password)
    {
        _password = password;
    }

    internal void GetPanel(GameObject workPanel)
    {
        _panel = workPanel;
    }

    internal void DestroyPanelOnCancel()
    {
        Destroy(gameObject);
        Destroy(_panel);
    }

    internal void PanelOnEnter()
    {
        _panel.SetActive(true);
        Destroy(gameObject);
    }
}
