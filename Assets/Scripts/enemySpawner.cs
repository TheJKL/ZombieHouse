using UnityEngine;
using UnityEngine.UI;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyType;
    public GameObject player;
    public GameObject windowBoard;
    public int maxBoards;
    private int boards;
    public Text counter;

    private void Start()
    {
        boards = maxBoards;
        updateBoards();
        GameObject.FindWithTag("GameController").GetComponent<GameController>().addSpawner(this); //add spawner to controller list
    }

    private void OnTriggerStay2D(Collider2D collision)//TODO This may need to be moved into the player object (centralize the control)
    {
        if(boards < maxBoards)
        {
            boards++;
            updateBoards();
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
            updateBoards();
            return;
        } 
        else if (boards == 1)
        {
            boards--;
            updateBoards();
        }
        windowBoard.SetActive(false);
        GameObject zombie = Instantiate(enemyType, transform);
        zombie.GetComponent<zombie>().setTarget(player);
    }

    private void updateBoards()
    {
        counter.text = $"{boards}/{maxBoards}";
    }
}
