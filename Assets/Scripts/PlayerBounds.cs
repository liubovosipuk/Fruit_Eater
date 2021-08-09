using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private float minX, maxX;
    private void Start()
    {
        // that give us width and height of the screen device 
        Vector3 coordinates = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minX = -coordinates.x + 0.3f;
        maxX = coordinates.x - 0.3f;

        // Another way to check our bounds is a hard coding positions of bounds 
        // Smth like that 
        // minX = -2.05f;
        // maxX = 2.05f; 

    }

    
    private void Update()
    {
        // Getting current possition of our player
        Vector3 temp = transform.position;

        if (temp.x > maxX)
            temp.x = maxX;

        if (temp.x < minX)
            temp.x = minX;

        transform.position = temp;
    }

} // class
































