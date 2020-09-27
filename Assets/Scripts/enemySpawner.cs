using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyType;
    public GameObject player;
    public float spawnTime;
    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Time.time;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            spawn();
        }
    }

    public void spawn()//TODO move spawn control to a seperate object (to allow for different types of spawners)
    {
        GameObject zombie = Instantiate(enemyType, transform);
        zombie.GetComponent<zombie>().setTarget(player);
        nextSpawnTime = Time.time + spawnTime;
    }
}
