using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyType;
    public GameObject player;
    public GameObject windowBoard;
    public int maxBoards;
    private int boards;

    private void Start()
    {
        boards = maxBoards;

        GameObject.FindWithTag("GameController").GetComponent<GameController>().addSpawner(this); //add spawner to controller list
    }

    private void OnTriggerStay2D(Collider2D collision)//TODO This may need to be moved into the player object (centralize the control)
    {
        if(boards < maxBoards)
        {
            boards++;
            windowBoard.SetActive(true);
            Debug.Log($"Boards Added, Boards = {boards}");
        }
    }

    public void attemptSpawn()
    {
        Debug.Log("Spawn Attempted");
        if(boards > 1)
        {
            boards--;
            return;
        } 
        else if (boards == 1)
        {
            boards--;
        }
        windowBoard.SetActive(false);
        GameObject zombie = Instantiate(enemyType, transform);
        zombie.GetComponent<zombie>().setTarget(player);
    }
}
