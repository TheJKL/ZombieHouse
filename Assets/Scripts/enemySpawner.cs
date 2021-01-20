using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyType;
    public GameObject player;
    public GameObject windowBoard;
    public float spawnTime;
    private float nextSpawnTime;
    public int maxBoards;
    private int boards;

    private void Start()
    {
        nextSpawnTime = Time.time + spawnTime;
        boards = maxBoards;

        GameObject.FindWithTag("GameController").GetComponent<GameController>().addSpawner(this); //add spawner to controller list
    }

    void Update()
    {
        bool offCooldown = Time.time >= nextSpawnTime;

        if (offCooldown && boards == 0)
        {
            spawn();
        }
        else if (offCooldown && boards > 0)
        {
            boards--;
            resetCooldown();
            Debug.Log($"Boards Removed, Boards = {boards}");
            updateBoard();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)//This may need to be moved into the player object (centralize the control)
    {
        if(boards < maxBoards)
        {
            boards++;
            updateBoard();
            Debug.Log($"Boards Added, Boards = {boards}");
        }
    }

    public void spawn()//TODO move spawn control to a seperate object (to allow for different types of spawners)
    {
        GameObject zombie = Instantiate(enemyType, transform);
        zombie.GetComponent<zombie>().setTarget(player);
        resetCooldown();
    }

    public void resetCooldown()
    {
        nextSpawnTime = Time.time + spawnTime;
    }

    public void updateBoard()
    {
        if(boards > 0)
        {
            windowBoard.SetActive(true);
        }
        else
        {
            windowBoard.SetActive(false);
        }
    }
}
