using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SquadGameManager : MonoBehaviour
{
    public KeyCode restart;
    public static int PlayerScore1 = 10;
    public static int PlayerScore2 = 10;
    public static int PlayerScore3 = 10;
    public static int PlayerScore4 = 10;
    public GUISkin layout;
    public GUISkin white;
    public GUISkin green;
    public GUISkin yellow;
    public GUISkin blue;
    GameObject theBall;
    int t = 0;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    void Update()
    {
        if (Input.GetKey(restart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            PlayerScore1 = 10;
            PlayerScore2 = 10;
            PlayerScore3 = 10;
            PlayerScore4 = 10;
            theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

        //Auto-Home
        if (Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                PlayerScore1 = 10;
                PlayerScore2 = 10;
                PlayerScore3 = 10;
                PlayerScore4 = 10;
                theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                PlayerScore1 = 10;
                PlayerScore2 = 10;
                PlayerScore3 = 10;
                PlayerScore4 = 10;
                theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
            }
        }

        //Simply Quit
        if (Input.GetKey(KeyCode.RightAlt))
        {
            if (Input.GetKey(KeyCode.F4))
            {
                Debug.Log("Quit");
                Application.Quit();
            }
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (Input.GetKey(KeyCode.F4))
            {
                Debug.Log("Quit");
                Application.Quit();
            }
        }
    }

    public static void Score(string wallID)
    {
        if (wallID == "LeftGoal")
        {
            PlayerScore1--;
        }
        if (wallID == "TopGoal")
        {
            PlayerScore2--;
        }
        if (wallID == "RightGoal")
        {
            PlayerScore3--;
        }
        if (wallID == "BotGoal")
        {
            PlayerScore4--;
        }
    }

    void OnGUI()
    {
        t++;
        GUI.skin = layout;

        if (PlayerScore1 == 0)
        {
            if (t % 100 < 50)
            {
                GUI.Button(new Rect(Screen.width / 2 - 780, 450, 1550, 200), "WHITE PLAYER LOSE");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (PlayerScore2 == 0)
        {
            if (t % 100 < 50)
            {
                GUI.Button(new Rect(Screen.width / 2 - 750, 450, 1500, 200), "GREEN PLAYER LOSE");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        if (PlayerScore3 == 0)
        {
            if (t % 100 < 50)
            {
                GUI.Button(new Rect(Screen.width / 2 - 810, 450, 1630, 200), "YELLOW PLAYER LOSE");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        if (PlayerScore4 == 0)
        {
            if (t % 100 < 50)
            {
                GUI.Button(new Rect(Screen.width / 2 - 750, 450, 1500, 200), "BLUE PLAYER LOSE");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }

        GUI.skin = white;
        GUI.Label(new Rect(Screen.width / 2 + 100 - 900, 15, 300, 300), "" + PlayerScore1);
        GUI.skin = green;
        GUI.Label(new Rect(Screen.width / 2 + 100 - -650, 15, 300, 300), "" + PlayerScore2);
        GUI.skin = yellow;
        GUI.Label(new Rect(Screen.width / 2 + 100 - -650, 945, 300, 300), "" + PlayerScore3);
        GUI.skin = blue;
        GUI.Label(new Rect(Screen.width / 2 + 100 - 900, 945, 300, 300), "" + PlayerScore4);
    }
}
