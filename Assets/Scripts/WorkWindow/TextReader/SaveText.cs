using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class SaveText : MonoBehaviour
{
    private string _text;

    public string Text => _text;

    public void OnSaveText(TMP_InputField text) 
    { 
        this._text = text.text;
        Debug.Log(this._text);
    }
}
