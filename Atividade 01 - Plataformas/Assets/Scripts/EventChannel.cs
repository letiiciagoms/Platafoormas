using System;
using UnityEngine;

public static class EventChannel
{
    public static Action<string> OnButtonPressed;

    public static void PressedButton(string doorId)
    {
       OnButtonPressed?.Invoke(doorId);
    }   
}
