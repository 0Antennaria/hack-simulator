using TMPro;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    [SerializeField] private SavePassword _savePassword;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private Animator _animation;

    public void OnClick()
    {
        if (_savePassword.Password == _inputField.text)
        {
            _savePassword.PanelOnEnter();
        }
        else
        {
            _animation.SetTrigger("wrong");
        }
    }
}
