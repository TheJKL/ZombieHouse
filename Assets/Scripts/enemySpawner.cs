using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyType;
    public GameObject player;
    void Update()
    {
        GameObject zombie = Instantiate(enemyType,transform);
        zombie.GetComponent<zombie>().setTarget(player);
    }
}
