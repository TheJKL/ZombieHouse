using UnityEngine;

public class ammoBox : MonoBehaviour
{

    public int ammo;

    void OnTriggerStay2D(Collider2D collision)
    {
        collision.GetComponent<PlayerStats>().incrementAmmo(ammo);
        Destroy(gameObject);
    }
}
