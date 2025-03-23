using UnityEngine;

public class CancelButton : MonoBehaviour
{
    [SerializeField] private SavePassword _savePassword;
    public void OnCkick()
    {
        _savePassword.DestroyPanelOnCancel();
    }
}
