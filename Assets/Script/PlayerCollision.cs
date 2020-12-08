using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMov movement; // Reference to our playerMov script

    //This function runs when we hit another  object
    // We get information about the collition and call it "collisionInfo"

    private void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collied with has a tag "Obstacle"
        if(collisionInfo.collider.tag == "Obstacle")
        {
            // disable player whe hit the obstacle
            movement.enabled = false;
            // Another way to find scritp
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
