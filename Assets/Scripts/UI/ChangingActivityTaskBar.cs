using UnityEngine;

public class ChangingActivityTaskBar : MonoBehaviour
{
    public void ChangeActivity(GameObject gameObject)
    {
        if(gameObject.activeSelf == true)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
