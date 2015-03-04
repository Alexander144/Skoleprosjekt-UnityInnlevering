using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {


	public GameObject Hitmarker;
	public AudioClip hitmarker;
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Ball") {
			Destroy(gameObject);
			AudioSource.PlayClipAtPoint(hitmarker,transform.position);
			Instantiate(Hitmarker, transform.position, Quaternion.identity);
			GM.instance.DestroyBrick();
			if(gameObject.tag == "Blue"){
				Lyd.blue++;
				Ball.blue++;
			}
			else if(gameObject.tag == "Red"){
				Lyd.red++;
			}
			else if(gameObject.tag == "Yellow"){
				Lyd.yellow++;
			}
			else if(gameObject.tag == "Green"){
				Lyd.green++;
				Lyd.trippelGreen++;
			}
		}
	}
}
