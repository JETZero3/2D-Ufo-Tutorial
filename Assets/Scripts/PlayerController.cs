using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    // Variable to control the speed of the object
    public float speed;

    // Variable for the rigid body component of the player
    private Rigidbody2D ufo;

    void Start()
    {
        // Get a reference to the rigid body component, and store in a variable. 
        ufo = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate()
    {
        // Store horizontal input
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Store vertical input
        float moveVertical = Input.GetAxis("Vertical");

        // Make a Vector2 variable based on the inputs from the keyboard
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Make a force of the player input multiplied by the speed set. 
        ufo.AddForce(movement * speed);
    }
}
