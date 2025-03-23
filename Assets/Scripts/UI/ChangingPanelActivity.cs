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

    public void TurnOnOrOffPanel(GameObject panel)
    {
        if (panel.activeSelf == true)
            panel.SetActive(false);
        else
            panel.SetActive(true);
    }

}
