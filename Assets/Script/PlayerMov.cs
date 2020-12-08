using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    
	// 
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // GAME OVER Conditions

        // if Fall from the plataform
        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
        //

    }
}
