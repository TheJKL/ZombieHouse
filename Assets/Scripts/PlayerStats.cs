using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    public float maxHealth;
    private float health;
    public int maxAmmo;
    public int startAmmo;
    private int ammo;
    public Text healthUI;
    public Text ammoUI;

    private void Start()
    {
        ammo = startAmmo;
        health = maxHealth;
        incrementAmmo(0);
        updateHealth();
    }

    public void damage(float dmg)
    {
        health -= dmg;
        updateHealth();
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void incrementAmmo(int increment)
    {
        ammo += increment;
        ammoUI.text = $"{ammo}/{maxAmmo}";
    }

    public int getAmmo()
    {
        return ammo;
    }

    public void updateHealth()
    {
        healthUI.text = $"{health}/{maxHealth}";
    }
}
