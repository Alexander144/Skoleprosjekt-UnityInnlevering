using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {


	public GameObject Hitmarker;
	
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Ball") {
			Destroy(gameObject);
			Instantiate(Hitmarker, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
		}
	}
}
