using UnityEngine;

public class zombieDamage : MonoBehaviour
{

    public float damage;
    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerStats>().damage(damage);
    }
}
