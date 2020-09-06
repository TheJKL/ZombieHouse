using UnityEngine;

public class zombie : MonoBehaviour
{
    public float health;
    void Update()
    {
        
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
