using UnityEngine;

public class CloseProgramTracking : MonoBehaviour
{
    private OpenFileOnClick _iconOnTaskBar;
    public void GetIcon(OpenFileOnClick icon)
    {
        _iconOnTaskBar = icon;
    }

    public void DestroyIcon()
    {
        _iconOnTaskBar.DestroyIcon();
    }
}
