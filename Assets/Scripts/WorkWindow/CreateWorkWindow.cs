using UnityEngine;

public class CreateWorkWindow : MonoBehaviour
{
    [SerializeField] private ActiveSlot _container;

    public void Create(GameObject program)
    {
        GameObject _program = Instantiate(program, _container.CurrentSlot.transform);
    }
}
