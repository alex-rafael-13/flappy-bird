using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    private void Update()
    {
        //Moves the pipes across the screen
        transform.position += Vector3.left * speed * Time.deltaTime;

        //Removing pipes at the end of the screen
        // if(transform.position.x > leftEdge){
        //     Destroy(gameObject);
        // }
    }
}
