using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    int t = 0;
    public GUISkin layout;

    void OnGUI()
    {
        t++;

        GUI.skin = layout;

        GUI.Button(new Rect(Screen.width / 2 - 155, 80, 330, 100), "MODES");
        if (t % 100 < 50)
        {
            GUI.Label(new Rect(Screen.width / 2 - 530, 380, 280, 50), "SOLO GAMING");
            GUI.Label(new Rect(Screen.width / 2 - -330, 380, 280, 50), "VERSUS BATTLE");
            GUI.Label(new Rect(Screen.width / 2 - 580, 800, 350, 100), "KING PONG RUMBLE");
            GUI.Label(new Rect(Screen.width / 2 - -380, 780, 350, 100), "DOUBLES");
        }
        //GUI.Button(new Rect(Screen.width / 2 - 350, 50, 700, 50), "FIRST WHO GET THE TEN POINTS, WINS!!!");
        /*
        //TWO PLAYER MODE
        GUI.Label(new Rect(Screen.width / 2 - 550, 480, 280, 50), "CONTROLS:");
        GUI.Label(new Rect(Screen.width / 2 - 550, 530, 280, 50), "PLAYER ONE: W, S");
        GUI.Label(new Rect(Screen.width / 2 - 550, 580, 380, 50), "PLAYER TWO: UP ARROW,");
        GUI.Label(new Rect(Screen.width / 2 - 345, 610, 380, 50), "DOWN ARROW");

        //ONE PLAYER MODE
        GUI.Label(new Rect(Screen.width / 2 - -80, 480, 280, 50), "CONTROLS:");
        GUI.Label(new Rect(Screen.width / 2 - -80, 530, 280, 50), "YOU: W, S");*/
    }
}
