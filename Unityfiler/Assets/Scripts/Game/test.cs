using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Ball") {
			if(gameObject.tag == "Blue"){
				Debug.Log("blue");
			}
			else if(gameObject.tag == "Green"){
				Debug.Log("green");
			}
			else if(gameObject.tag == "Yellow"){
				Debug.Log("yellow");
			}
			else if(gameObject.tag == "Red"){
				Debug.Log("red");
			}
			Destroy(gameObject);
		}
	}
}
