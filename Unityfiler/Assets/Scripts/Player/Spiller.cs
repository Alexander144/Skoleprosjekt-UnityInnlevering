using UnityEngine;
using System.Collections;

public class Spiller : MonoBehaviour { 	
	// Update is called once per frame
	public KeyCode left;
	public KeyCode right;
	void Update (){
		var speed = 20f;
		rigidbody2D.velocity = new Vector2(0,0);
		if (Input.GetKey(left)) {
			rigidbody2D.velocity = new Vector2(speed*-1,rigidbody2D.velocity.y);
		} 
		else if (Input.GetKey(right)) {
			rigidbody2D.velocity = new Vector2(speed,rigidbody2D.velocity.y);
		} 
		else {
			rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
		}
	}
}
