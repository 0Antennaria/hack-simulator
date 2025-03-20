using System;
using UnityEngine;

public class SavePassword : MonoBehaviour
{
    private string _password;
    private GameObject _panel;

    public void GetPassword(string password)
    {
        _password = password;
    }

    internal void GetPanel(GameObject workPanel)
    {
        _panel = workPanel;
    }
}
