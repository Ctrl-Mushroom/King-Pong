using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AILoadScene : AIGameManager
{
    public void SceneLoader(int SceneIndex)
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        SceneManager.LoadScene(SceneIndex);
    }
}
