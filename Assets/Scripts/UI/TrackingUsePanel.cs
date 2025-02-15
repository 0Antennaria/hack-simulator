using UnityEngine;
using UnityEngine.EventSystems;

public class TrackingUsePanel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private CreateParametrPnael _createParametrPnael;

    private void Start()
    {
        _createParametrPnael = FindAnyObjectByType<CreateParametrPnael>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _createParametrPnael.OffPanel();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _createParametrPnael.OnPanel();

    }
}
