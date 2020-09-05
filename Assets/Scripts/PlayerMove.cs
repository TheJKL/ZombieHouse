using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveForce;
    public float maxSpeed;

    void Update()
    {
        Rigidbody2D playerBody = gameObject.GetComponent<Rigidbody2D>();
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 move = transform.right * x + transform.up * y;

        if(playerBody.velocity.magnitude < maxSpeed)
        {
            playerBody.AddForce(move * moveForce);
        } 
    }
}
