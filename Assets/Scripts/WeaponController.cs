using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject bulletPrefab;
    public PlayerLook playerSprite;

    public float bulletVelocity;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab,transform.position,transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            float angle = playerSprite.angle * Mathf.Deg2Rad;
            Vector2 direction = new Vector2(Mathf.Cos(angle),Mathf.Sin(angle));
            rb.velocity = bulletVelocity * direction;
        }
    }
}
