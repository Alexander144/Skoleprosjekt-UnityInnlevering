using UnityEngine;
using System.Collections;

public class Spiller : MonoBehaviour { 	
	// Update is called once per frame
	void Update () {
		var speed = 10f;
<<<<<<< HEAD
=======

>>>>>>> 8e47f946190ed033b0e7e402d32e236326a2c87a
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rigidbody2D.velocity = new Vector2(speed*-1,rigidbody2D.velocity.y);
		} 
		else if (Input.GetKey(KeyCode.RightArrow)) {
			rigidbody2D.velocity = new Vector2(speed,rigidbody2D.velocity.y);
		} 
		else {
			rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
		}
	}
}
