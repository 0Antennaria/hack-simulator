using System;
using UnityEngine;

public class CreateProgram : MonoBehaviour
{
    [SerializeField] private ActiveSlot _container;

    public void Create(GameObject program)
    {
        Debug.Log(_container.CurrentSlot);
        var _program = Instantiate(program, _container.CurrentSlot.transform) as GameObject;
    }
}
