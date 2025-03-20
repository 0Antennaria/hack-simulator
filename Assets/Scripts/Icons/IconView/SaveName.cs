using UnityEngine;

public class SaveName : MonoBehaviour
{
    [SerializeField] private string _name;

    private IconView _iconView;

    public string Name => _name;

    private void Start()
    {
        _iconView = GetComponent<IconView>();

        _name = _iconView._typefile.Name;
    }

    public void LoadName(string name)
    {
        _name = name;
    }
}
