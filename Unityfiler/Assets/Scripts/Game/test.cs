using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	// Use this for initialization
public bool blue = false;
public bool green = false;
public bool yellow = false;
public bool red = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (blue);
	}
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Ball") {
			if(gameObject.tag == "Blue"){
				blue = true;
				Debug.Log(blue);
			}
			else if(gameObject.tag == "Green"){
				green = true;
				Debug.Log(green);
			}
			else if(gameObject.tag == "Yellow"){
				yellow = true;
				Debug.Log(yellow);
			}
			else if(gameObject.tag == "Red"){
				red = true;
				Debug.Log(red);
			}
			if(blue == true){
				blue = false;
				green = false;
				red = false;
				yellow = false;
				Debug.Log("tripple");
			}
			Destroy(gameObject);
		}
	}
}
