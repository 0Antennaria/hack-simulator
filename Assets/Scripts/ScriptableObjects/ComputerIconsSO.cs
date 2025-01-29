using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Icon", menuName = "PC/Create Icon")]
public class ComputerIconsSO : ScriptableObject
{
    [SerializeField] private Sprite _imageIcon;
    [SerializeField] private string _name;
    [SerializeField] private GameObject _openingApplication;

    public Sprite ImageIcon => _imageIcon;
    public string Name => _name;
    public GameObject OpeningApplication => _openingApplication;

}
