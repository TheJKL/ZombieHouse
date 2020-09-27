using UnityEngine;

public class zombie : MonoBehaviour
{
    public float health;
    public GameObject player;

    public float moveSpeed;
    public float moveForce;

    void Update()
    {
        Vector2 playerPos = player.transform.position;
        Vector2 zomPos = gameObject.transform.position;
        Rigidbody2D bd = gameObject.GetComponent<Rigidbody2D>();

        bd.rotation = Mathf.Atan2(playerPos.y - zomPos.y, playerPos.x - zomPos.x) * Mathf.Rad2Deg;
        if (bd.velocity.magnitude < moveSpeed)
        {
            bd.AddForce(gameObject.transform.right * moveForce);
        }
    }

    public void damage(float dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void setTarget(GameObject target)
    {
        player = target;
    }
}
