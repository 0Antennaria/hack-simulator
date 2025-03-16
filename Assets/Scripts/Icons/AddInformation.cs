using System;
using UnityEngine;
using UnityEngine.Events;

public class AddInformation : MonoBehaviour
{
    private GameObject _currentPanel;

    public void AddApplication(GameObject panel)
    {
        _currentPanel = panel;
        Debug.Log(_currentPanel);
    }    

}
