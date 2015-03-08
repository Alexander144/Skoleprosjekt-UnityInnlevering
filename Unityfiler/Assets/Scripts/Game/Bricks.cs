using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {
	public static bool finnes = false;
	
	public GameObject Hitmarker;
	public AudioClip hitmarker;
	void OnCollisionEnter2D (Collision2D other) {
		if (other.collider.tag == "Ball") {
			if(finnes == false){
				int randomNumber = Random.Range (1, 10);
				Debug.Log(randomNumber);
				if(randomNumber == 2){
					Doritospose.spawn = true;
					GameObject.FindWithTag("DoritosPose").transform.position = gameObject.transform.position;
					finnes = true;
				}
			}
			else{GameObject.FindWithTag("DoritosPose").transform.position = GameObject.FindWithTag("DoritosPose").transform.position;}
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