using System;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private TMP_Text _clock;

    private void Update()
    {
        DateTime currenttime = DateTime.Now;

        _clock.text = currenttime.ToString("HH:mm:ss");
    }
}
