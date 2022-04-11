using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public KeyCode restart;
    public KeyCode esc;
    public bool again;
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
    public GUISkin layout;
    GameObject theBall;
    int t = 0;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    void Update()
    {
        if (again == true)
        {
            if (Input.GetKey(esc))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                PlayerScore1 = 0;
                PlayerScore2 = 0;
                theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
            }
        }
        if (Input.GetKey(restart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            PlayerScore1 = 0;
            PlayerScore2 = 0;
            theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

        //Auto-Home
        if (again == false)
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
                    PlayerScore1 = 0;
                    PlayerScore2 = 0;
                    theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
                }
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
                    PlayerScore1 = 0;
                    PlayerScore2 = 0;
                    theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
                }
            }
        }

        //Simply Quit
        if(Input.GetKey(KeyCode.RightAlt))
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
        if (wallID == "RightGoal")
        {
            PlayerScore1++;
        }
        else
        {
            PlayerScore2++;
        }
    }

    void OnGUI()
    {
        t++;
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 130, -3, 300, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 50, -3, 300, 100), "" + PlayerScore2);
        GUI.Label(new Rect(Screen.width / 2 - 800, -3, 800, 100), "PLAYER ONE");
        GUI.Label(new Rect(Screen.width / 2 - -180, -3, 800, 100), "PLAYER TWO");

        if (PlayerScore1 == 10)
        {
            if (t % 100 < 50)
            {
                GUI.Button(new Rect(Screen.width / 2 - 700, 400, 1500, 200), "PLAYER ONE WINS");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (PlayerScore2 == 10)
        {
            if (t % 100 < 50)
            {
                GUI.Button(new Rect(Screen.width / 2 - 700, 400, 1500, 200), "PLAYER TWO WINS");
            }
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }
}
