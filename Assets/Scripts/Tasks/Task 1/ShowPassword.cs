using TMPro;
using UnityEngine;

public class ShowPassword : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private GameObject _panel;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TryShowPassword()
    {
        if(_inputField.text == "HELLO")
        {
            Destroy(_panel);
            Debug.Log("wwww");
        }
        else
        {
            Debug.Log("wwww");
            Debug.Log(_inputField.text);
            _animator.SetTrigger("wrong");
        }

    }
    
}
