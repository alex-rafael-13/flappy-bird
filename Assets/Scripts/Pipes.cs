// using System.Collections;
// using System.Collections.Generic;
// using System.Numerics;
// using System.Runtime.CompilerServices;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    //Grabbing the left edge of screen once game starts
    private void Start()
    {
        //Camera.main looks for the camera that is called Main Camera
        //Left edge of screen is zero
        //ScreenToWorldPoint gets any position of the screen that you need then turns it into a world point, they take Vector2 and Vector3
        //Since we want the left edge of screen, call the ScreenToWorldPoint function with a vector (0,0,0), since left edge is zero
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f; //Only need the x coordinate, subtract by one to find the offscreen point
    }

    private void Update()
    {
        //Moves the pipes across the screen
        transform.position += Vector3.left * speed * Time.deltaTime;

        //Removing pipes at the end of the screen
        if(transform.position.x < leftEdge){ //Checks if pipe has reached the left edge
            Destroy(gameObject);
        }
    }
}
