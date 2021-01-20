using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{

    public List<enemySpawner> spawners;

    void Update()
    {
        
    }

    public void addSpawner(enemySpawner spawner)
    {
        spawners.Add(spawner);
        Debug.Log("added spawner");
    }
}
