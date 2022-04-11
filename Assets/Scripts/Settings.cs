using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GUISkin layout;

    void OnGUI()
    {
        GUI.skin = layout;

        GUI.Label(new Rect(Screen.width / 2 - 130, 100, 280, 50), "SETTINGS");
        GUI.Label(new Rect(Screen.width / 2 - 200, 350, 280, 50), "SFX:");
    }
}
