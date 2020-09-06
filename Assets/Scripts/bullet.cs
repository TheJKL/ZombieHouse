using UnityEngine;

public class bullet : MonoBehaviour
{
    public LayerMask noHit;
    public float damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        zombie hit = collision.gameObject.GetComponent<zombie>();
        if(hit != null)
        {
            hit.damage(damage);
        }
        Destroy(gameObject);
    }
}
