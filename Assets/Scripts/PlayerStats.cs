using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    
    public float maxHealth;
    private float health;

    private void Start()
    {
        health = maxHealth;
    }

    public void damage(float dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
