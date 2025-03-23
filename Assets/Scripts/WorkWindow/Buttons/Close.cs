using UnityEngine;

public class Close : MonoBehaviour
{
    [SerializeField] private CloseProgramTracking _workPanel;

    public void ClosePanel(GameObject gameobject)
    {
        _workPanel.DestroyIcon();


        Destroy(gameobject);
    }
}
