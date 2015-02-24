using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var randomNumber = Random.Range (0f, 2f);
		if(randomNumber <= 0.5){
			rigidbody2D.AddForce(new Vector2(40, 70));
		}
		else{
			rigidbody2D.AddForce(new Vector2(-40, 70));
		}
	}	
	void Update(){
		Debug.Log (rigidbody2D.velocity.magnitude);
		//if (rigidbody2D.velocity.magnitude>20) {
		//	rigidbody2D.velocity = rigidbody2D.velocity * 0.9f;
		//}
		//if (rigidbody2D.velocity.magnitude<10) {
		//	rigidbody2D.velocity = rigidbody2D.velocity * 1.9f;
		//}
}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Spiller") {
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x/2,rigidbody2D.velocity.y) + new Vector2(Info.collider.rigidbody2D.velocity.x/3,Info.collider.rigidbody2D.velocity.y);
		}
		if(Info.collider.tag=="Bunngrense"){
			rigidbody2D.position = new Vector2(0,0);
			rigidbody2D.velocity = rigidbody2D.velocity * 0f;
			var randomNumber = Random.Range (0f, 2f);
			if(randomNumber <= 0.5){
				rigidbody2D.AddForce(new Vector2(40, 70));
			}
			else{
				rigidbody2D.AddForce(new Vector2(-40, 70));
			}
		}
	}
}
