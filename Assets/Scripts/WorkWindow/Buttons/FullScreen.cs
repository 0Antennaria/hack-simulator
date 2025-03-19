using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public void FullScreenPanel(RectTransform gameObject)
    {
        float width = (Screen.width / 2);
        float height = (Screen.height / 2);

        gameObject.position = new Vector3(width, height, 0);
    }
}
