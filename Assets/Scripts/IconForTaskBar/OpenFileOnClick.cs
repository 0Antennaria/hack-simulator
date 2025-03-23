using UnityEngine;

public class OpenFileOnClick : MonoBehaviour
{
    private GameObject _workWindowPanel;

    private void Update()
    {
        if (_workWindowPanel == null)
            DestroyIcon();
    }

    public void SavePanelWhoCreate(GameObject panel)
    {
        _workWindowPanel = panel;

        if(_workWindowPanel.TryGetComponent<CloseProgramTracking>(out CloseProgramTracking program))
        {
            program.GetIcon(this);
        }
    }

    public void ShowPanel()
    {
        _workWindowPanel.SetActive(true);
    }

    public void DestroyIcon()
    {
        Destroy(gameObject);
    }
}
