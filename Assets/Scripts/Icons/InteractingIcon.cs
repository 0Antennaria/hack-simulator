using UnityEngine;

public class InteractingIcon : MonoBehaviour
{
    private ActiveIconView _activeIcon;

    private void Awake()
    {
        _activeIcon = GetComponent<ActiveIconView>();
    }

    public void Destroy()
    {
        Destroy(_activeIcon.CurrentIcon.gameObject);
    }

    public void Show()
    {
        _activeIcon.CurrentIcon._inputField.gameObject.SetActive(true);
    }
}
