using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RandomText : MonoBehaviour
{
    public GUISkin layout;
    public Text textDisplay;


    int message = 0;

    public void Start()
    {
        message = Random.Range(1, 5);
    }

    public void OnGUI()
    {
        GUI.skin = layout;

        if (message == 1)
            GUI.Label(new Rect(Screen.width / 2 - 530, 750, 1500, 250), "You cannot win against the AI player.");
        if (message == 2)
            GUI.Label(new Rect(Screen.width / 2 - 280, 750, 700, 250), "Protect your Goal!!!");
        if (message == 3)
            GUI.Label(new Rect(Screen.width / 2 - 330, 750, 1000, 250), "Chill... It's only a game.");
        if (message == 4)
            GUI.Label(new Rect(Screen.width / 2 - 280, 750, 700, 250), "*PAUSE doesn't exist*");
        if (message == 5)
            GUI.Label(new Rect(Screen.width / 2 - 430, 750, 1000, 250), "Finish what youy've started...");
    }
}
