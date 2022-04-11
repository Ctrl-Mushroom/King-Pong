using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndlessGameManager : MonoBehaviour
{
    public KeyCode restart;
    public static int PlayerScore1 = 0;
    public GUISkin layout;
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
            PlayerScore1 = 0;
            theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

        //Auto-Home
        if (Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
                PlayerScore1 = 0;
                theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
                PlayerScore1 = 0;
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
        if (wallID == "TopGoal")
        {
            PlayerScore1++;
        }
        if (wallID == "RightGoal")
        {
            PlayerScore1++;
        }
        if (wallID == "BotGoal")
        {
            PlayerScore1++;
        }
        if (wallID == "LeftGoal")
        {
            PlayerScore1++;
        }
    }

    void OnGUI()
    {
        t++;
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - -300, -3, 300, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 - 400, -3, 530, 100), "BOUNCE");
        
    }
}
