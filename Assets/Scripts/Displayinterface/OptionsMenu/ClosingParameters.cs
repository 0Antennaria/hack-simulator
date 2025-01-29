using UnityEngine;

public class ClosingParameters : MonoBehaviour
{
    public void TryClosePanel(GameObject parametrsMenu)
    {
        if(parametrsMenu.activeSelf == true)
            parametrsMenu.SetActive(false);
    }
}
