using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 10f;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
            
    }

    private void FixedUpdate()
    {
        Vector2 vel = myBody.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        myBody.velocity = vel;
    }

} // class















































