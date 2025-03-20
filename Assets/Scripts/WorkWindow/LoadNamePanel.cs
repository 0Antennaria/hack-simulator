using TMPro;
using UnityEngine;

public class LoadNamePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    public void LoadName(string name)
    {
        _text.text = name;
    }
}
