using UnityEngine;

public class BlockOpen : MonoBehaviour
{
    [SerializeField] private string _password;
    [SerializeField] private GameObject _blockPanel;
    [SerializeField] private GameObject _container;

    private GameObject _workPanel;

    public void OnBlockPanel()
    {
        GameObject blockPanel = Instantiate(_blockPanel, _container.transform);

        if (blockPanel.TryGetComponent<SavePassword>(out SavePassword block))
        {
            block.GetPassword(_password);
            block.GetPanel(_workPanel);
        }
    }

    internal void OnSavePanel(GameObject panel)
    {
        _workPanel = panel;
    }
}
