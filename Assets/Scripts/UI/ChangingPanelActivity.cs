using UnityEngine;

public class ChangingPanelActivity : MonoBehaviour
{
    public void TurnOnPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void TurnOffPanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
