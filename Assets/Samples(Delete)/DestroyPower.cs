using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPower : MonoBehaviour
{
    public Transform[] spawnPoints;
    public float destroyTime = 3f;
    public float spawnTime = 2.8f;
    public GameObject power;

    void Start()
    {
        InvokeRepeating("SpawnPower", spawnTime, spawnTime);
        Destroy(gameObject, destroyTime);
    }

    void SpawnPower()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(power, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
