using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool startSpill;
	public KeyCode space;
	public static int blue = 0;
	// Use this for initialization
	void Start () {
		startSpill = false;
		}
	void Update(){
		//Debug.Log (rigidbody2D.velocity.magnitude);
		if(startSpill == false){
		if(Input.GetKeyDown(space)){
				startSpill = true;
				startBall ();
		}
	}
		if(startSpill == true){
			check ();
		}
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
			startSpill = false;
<<<<<<< HEAD
			GM.instance.LoseLife();
=======
		}
		if(Info.collider.tag=="vegg" || Info.collider.tag == "Bunngrense"){
			Lyd.count = 0;
			Lyd.blue = 0;
			Lyd.green = 0;
			Lyd.yellow = 0;
			Lyd.red = 0;
>>>>>>> 6bb8687739d64376e627cd47954778b07717e381

		}
	}
	void startBall(){
		var randomNumber = Random.Range (0f, 2f);
		if(randomNumber <= 0.5){
			rigidbody2D.AddForce(new Vector2(2.5f, 10f));
		}
		else{
			rigidbody2D.AddForce(new Vector2(-2.5f, 10f));
		}
	}
	void check(){
		if (rigidbody2D.velocity.magnitude<6) {
			rigidbody2D.velocity = rigidbody2D.velocity * 1.3f;
		}
		if(rigidbody2D.velocity.magnitude == 30){
			rigidbody2D.velocity = rigidbody2D.velocity * 0.3f;
		}
		if((rigidbody2D.velocity.y < 1) && 
		   (Mathf.Sign(rigidbody2D.velocity.y) == 1))
		{
			rigidbody2D.AddForce(new Vector2(0, 5f));
		} 
		else if((rigidbody2D.velocity.y > -1) && 
		        (Mathf.Sign(rigidbody2D.velocity.y) == -1))
		{
			rigidbody2D.AddForce(new Vector2(0, -5f));
		}
		if(blue==6){
			rigidbody2D.velocity = rigidbody2D.velocity * 1.1f;
			blue = 0;
		}
	}
}