using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SquadLoadScene : SquadGameManager
{
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
        PlayerScore1 = 10;
        PlayerScore2 = 10;
        PlayerScore3 = 10;
        PlayerScore4 = 10;
    }
}
