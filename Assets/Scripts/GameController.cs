using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    [HideInInspector]
    public List<enemySpawner> spawners;
    public float spawnAttemptInterval;
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnAttemptInterval;
    }

    void Update()
    {
        if (nextSpawnTime < Time.time)
        {
            int idx = Random.Range(0, spawners.Count);
            spawners[idx].attemptSpawn();
            nextSpawnTime = Time.time + spawnAttemptInterval;
        }
    }

    public void addSpawner(enemySpawner spawner)
    {
        spawners.Add(spawner);
        Debug.Log("added spawner");
    }
}
