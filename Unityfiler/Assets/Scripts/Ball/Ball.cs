using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool startSpill;
	public KeyCode space;
	// Use this for initialization
	void Start () {
		startSpill = false;
		}
	void Update(){
		Debug.Log (rigidbody2D.velocity.magnitude);
		if (rigidbody2D.velocity.magnitude<8) {
			rigidbody2D.velocity = rigidbody2D.velocity * 1.3f;
		}
		if(startSpill == false){
		if(Input.GetKeyDown(space)){
				startSpill = true;
			var randomNumber = Random.Range (0f, 2f);
			if(randomNumber <= 0.5){
				rigidbody2D.AddForce(new Vector2(10, 40));
			}
			else{
				rigidbody2D.AddForce(new Vector2(-10, 40));
			}
		}
	}
		//if (rigidbody2D.velocity.magnitude<10) {
		//	rigidbody2D.velocity = rigidbody2D.velocity * 1.9f;
		//}
}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Spiller") {
			Debug.Log ("fungerer");
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x/2,rigidbody2D.velocity.y) + new Vector2(Info.collider.rigidbody2D.velocity.x/3,Info.collider.rigidbody2D.velocity.y);
		}
		if(Info.collider.tag=="Bunngrense"){
			rigidbody2D.position = new Vector2(0,0);
			rigidbody2D.velocity = rigidbody2D.velocity * 0f;
			startSpill = false;

		}
		if(Info.collider.tag=="VenstreVegg"){
			rigidbody2D.AddForce(new Vector2(-5, 5));
		}
		if(Info.collider.tag=="HoyereVegg"){
			Debug.Log("funker");
			rigidbody2D.AddForce(new Vector2(5, 5));
		}
	}
}