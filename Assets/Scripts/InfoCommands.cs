using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCommands : MonoBehaviour
{
    public GUISkin layout;

    void OnGUI()
    {
        GUI.skin = layout;

        GUI.Button(new Rect(Screen.width / 2 - 250, 80, 500, 100), "COMMANDS");

        //SOLO GAMING MODE
        GUI.Label(new Rect(Screen.width / 2 - 800, 300, 500, 50), "CONTROLS: SOLO GAMING");
        GUI.Label(new Rect(Screen.width / 2 - 800, 330, 500, 50), "YOU:   W, S");
        
        //VERSUS BATTLE MODE
        GUI.Label(new Rect(Screen.width / 2 - 800, 410, 500, 50), "CONTROLS: VERSUS BATTLE");
        GUI.Label(new Rect(Screen.width / 2 - 800, 440, 500, 50), "PLAYER ONE:   W, S");
        GUI.Label(new Rect(Screen.width / 2 - 800, 470, 650, 50), "PLAYER TWO:   UP ARROW, DOWN ARROW");
        
        //DOUBLES MODE
        GUI.Label(new Rect(Screen.width / 2 - 800, 550, 500, 50), "CONTROLS: DOUBLES");
        GUI.Label(new Rect(Screen.width / 2 - 800, 580, 600, 50), "BLUE-WHITE       :   W, S");
        GUI.Label(new Rect(Screen.width / 2 - 800, 610, 600, 50), "BLUE                        :   F, V");
        GUI.Label(new Rect(Screen.width / 2 - 800, 640, 600, 50), "YELLOW-WHITE:   O, L");
        GUI.Label(new Rect(Screen.width / 2 - 800, 670, 800, 50), "YELLOW                 :   UP ARROW, DOWN ARROW");

        //KING PONG RUMBLE MODE
        GUI.Label(new Rect(Screen.width / 2 - 800, 750, 550, 50), "CONTROLS: KING PONG RUMBLE");
        GUI.Label(new Rect(Screen.width / 2 - 800, 780, 500, 50), "WHITE     :   W, S");
        GUI.Label(new Rect(Screen.width / 2 - 800, 810, 650, 50), "GREEN     :   UP ARROW, DOWN ARROW");
        GUI.Label(new Rect(Screen.width / 2 - 800, 840, 500, 50), "YELLOW  :   A, D");
        GUI.Label(new Rect(Screen.width / 2 - 800, 870, 650, 50), "BLUE        :   LEFT ARROW, RIGHT ARROW");

        //CheatCode(for AI Only): SHIFT + X ; Skins(if possible...)
        GUI.Label(new Rect(Screen.width / 2 - -100, 300, 600, 50), "On Game Only!!!");
        GUI.Label(new Rect(Screen.width / 2 - -100, 330, 600, 50), "RESTART:   'SPACEBAR'");
        GUI.Label(new Rect(Screen.width / 2 - -100, 380, 600, 50), "MODES       :   'SHIFT' + 'ESCAPE'");
        GUI.Label(new Rect(Screen.width / 2 - -100, 430, 600, 50), "QUIT         :   'ALT' + 'F4'");
        GUI.Label(new Rect(Screen.width / 2 - -100, 500, 600, 50), "On Home Only!!!");
        GUI.Label(new Rect(Screen.width / 2 - -100, 530, 600, 50), "MULTIVERSE:   'CTRL' + 'ALT' + 'X'");
    }
}
