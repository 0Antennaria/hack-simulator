using UnityEngine;

public class ShowPanelAI : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private bool _isOpen = false;

    public void OpenPanel()
    {
        if (!_isOpen)
        {
            _animator.SetTrigger("open");
            _isOpen = true;
        }
        else if(_isOpen)
        {
            _animator.SetTrigger("close");
            _isOpen = false;
        }
    }
}
