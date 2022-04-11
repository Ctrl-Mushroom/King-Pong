using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    public static int PlayerScore4 = 10;
    public GUISkin blue;
    GameObject theBall;
    int t = 0;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Score(string wallID)
    {
        if (wallID == "BotGoal")
        {
            PlayerScore4--;
        }
    }

    void OnGUI()
    {

        t++;
        GUI.skin = blue;
        GUI.Label(new Rect(Screen.width / 2 + 100 - 0, 150, 100, 100), "" + PlayerScore4);
        //GUI.Label(new Rect(Screen.width / 2 - 400, -3, 530, 100), "YOU");
        //GUI.Label(new Rect(Screen.width / 2 - -180, -3, 500, 100), "PASSIVE BOT");

        if (GUI.Button(new Rect(Screen.width / 2 - 100, 700, 200, 50), "NEW GAME"))
        {
            PlayerScore4 = 10;
            theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

        if (PlayerScore4 == 0)
        {
            if (t % 100 < 50)
            {
                GUI.Label(new Rect(Screen.width / 2 - 300, 250, 2000, 1000), "YOU WIN");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
            if (GUI.Button(new Rect(Screen.width / 2 - 110, 355, 230, 50), "MAIN MENU"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
                PlayerScore4 = 10;
                theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 80, 430, 150, 50), "QUIT"))
            {
                Debug.Log("Quit");
                Application.Quit();
            }
        }
    }
}
