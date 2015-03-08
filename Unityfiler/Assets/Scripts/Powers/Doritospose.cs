using UnityEngine;
using System.Collections;

public class Doritospose : MonoBehaviour {
	public static bool spawn = false;
	// Use this for initialization
	void Start () {
		renderer.enabled = false;
		collider2D.enabled = false;
		rigidbody2D.AddForce(new Vector2(0f, -175f));
	}
	
	// Update is called once per frame
	void Update () {
		if(spawn == true){
			renderer.enabled = true;
			collider2D.enabled = true;
		}
		//Debug.Log (tell);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Spiller"){
			Doritos.DoritosStart = true;
			renderer.enabled = false;
			collider2D.enabled = false;
			Doritos.tell = 0f;
		}
		if(other.gameObject.tag == "Bunngrense"){
			renderer.enabled = true;
			collider2D.enabled = true;
			Bricks.finnes = false;
		}
	}
}
