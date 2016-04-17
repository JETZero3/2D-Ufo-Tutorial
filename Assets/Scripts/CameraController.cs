using UnityEngine;
using System.Collections;

// This script aims to center the camera around the player, while still having its own orientation relative to the background. 

public class CameraController : MonoBehaviour {

    // Reference to the player object
    public GameObject player;

    // Offset value is the camera position subtracted by the player position. 
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame, but is guaranteed to run after all objects have been processed in Update()
	void LateUpdate () {
        // The new position of the camera is the player's current position added by the difference between the camera and player. 
        transform.position = player.transform.position + offset;
	}
}
