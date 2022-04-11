using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TagLoadScene : TagTeamGameManager
{
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
        PlayerScore1 = 0;
        PlayerScore2 = 0;
    }
}
