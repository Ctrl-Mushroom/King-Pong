using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public Transform[] spawnPoints;
    public float spawnTime = 2f;
    public GameObject power;

    void Start()
    {
        InvokeRepeating("SpawnPower", spawnTime, spawnTime);
    }

    void Update()
    {
        
    }

    void SpawnPower()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(power, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
}
