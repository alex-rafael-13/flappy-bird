using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    
    public float gravity = -9.8f;
    public float strength = 5f;

    private void Update() //Inputs
    // Space bar or left click flaps the bird
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            direction = Vector3.up * strength;
        }
        //Touch screen inputs
        if (Input.touchCount > 0){ //Checks if the screen got touched at least once
            Touch touch = Input.GetTouch(0); //Gets first touch, disregarding the others

            if(touch.phase == TouchPhase.Began){ //Checks if touch just began
                direction = Vector3.up * strength;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime; //Framerate independent
    }
}
