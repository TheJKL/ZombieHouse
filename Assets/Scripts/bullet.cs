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
        if ((noHit.value & (1 << collision.gameObject.layer)) == 0)
        {
            Destroy(gameObject);
        }
    }
}
