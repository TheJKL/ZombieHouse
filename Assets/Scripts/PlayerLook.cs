using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera camera;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mousePos = camera.ViewportToWorldPoint(Input.mousePosition);

    }
}
