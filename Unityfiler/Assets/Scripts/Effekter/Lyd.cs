using UnityEngine;
using System.Collections;

public class Lyd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Ball"&&	gameObject.tag == "Blue") {
			Debug.Log("blue+1");
		}
	}
}