using System;
using UnityEngine;
using UnityEngine.Events;

public class PinAnIcon : MonoBehaviour
{
    [SerializeField] private GetNewIcons _container;
    [SerializeField] private GameObject _iconForTaskBar;
    
    private InventoryIcon _inventoryIcon;

    private void OnEnable()
    {
        _inventoryIcon = GetComponent<InventoryIcon>();


        _inventoryIcon.AddIconForTaskBar += AddIconOnTaskBar;
    }
    private void OnDisable()
    {
        _inventoryIcon.AddIconForTaskBar -= AddIconOnTaskBar;
    }
    private void Start()
    {
        _container = FindAnyObjectByType<GetNewIcons>();
    }

    public void AddIconOnTaskBar(GameObject panel)
    {
        GameObject icon = Instantiate(_iconForTaskBar, _container.transform);

        if(icon.TryGetComponent<OpenFileOnClick>(out OpenFileOnClick iconForTask))
        {
            iconForTask.SavePanelWhoCreate(panel);
        }
    }
}
