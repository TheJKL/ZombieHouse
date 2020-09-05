using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public new Camera camera;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 lookRot = mousePos - playerPos;

        float angle = Mathf.Atan2(lookRot.y, lookRot.x) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.forward * angle;
    }
}
