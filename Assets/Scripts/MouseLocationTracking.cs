using UnityEngine;

public class MouseLocationTracking : MonoBehaviour
{
    private Vector3 _positionMouse;

    public Vector3 PositionMouse => _positionMouse;

    private void Update()
    {
        _positionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
