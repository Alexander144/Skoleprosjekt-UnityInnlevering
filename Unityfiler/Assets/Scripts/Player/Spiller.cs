using UnityEngine;
using System.Collections;

public class Spiller : MonoBehaviour { 	
	// Update is called once per frame
	void Update () {
		var speed = 10f;

		int trololo = 5;
<<<<<<< HEAD

	
		int test = 1;
		int test3 = 5;
		int test2 = 1;

		int ley = 2;

		int hey = 1;

		int shave = 2;
=======
		int det = 1;
>>>>>>> 9a948131c6f7aa6b2fdaf1e388ff0a2c783e03fe
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
