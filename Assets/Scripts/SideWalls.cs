using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            AIGameManager.Score(wallName);
            SquadGameManager.Score(wallName);
            TagTeamGameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1, SendMessageOptions.RequireReceiver);
            GetComponent<AudioSource>().Play();
        }
    }
}
