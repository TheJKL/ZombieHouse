using UnityEngine;

public class zombieDamage : MonoBehaviour
{

    public float damage;
    public float damageCooldown;
    private float nextDamageTime;

    private void Start()
    {
        nextDamageTime = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Time.time >= nextDamageTime)
        {
            nextDamageTime = Time.time + damageCooldown;
            collision.gameObject.GetComponent<PlayerStats>().damage(damage);
        }
    }
}
