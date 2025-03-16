using UnityEngine;

public class CreateWorkWindow : MonoBehaviour
{
    [SerializeField] private CreateWorkWindow _container;

    private void Awake()
    {
        _container = GetComponent<CreateWorkWindow>();
    }

    public void Create(GameObject program)
    {
        GameObject _program = Instantiate(program, _container.transform);
    }

    public GameObject CreateAndReturn(GameObject program)
    {
        return Instantiate(program, _container.transform);
    }
}

