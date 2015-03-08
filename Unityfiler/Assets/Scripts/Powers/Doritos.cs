using UnityEngine;
using System.Collections;
using System.Threading;

public class Doritos : MonoBehaviour {
	public static bool DoritosStart = false;
	public static float tell;
	public static bool stopp;
	// Use this for initialization
	void Start () {
		tell = 20;
		stopp = false;
		gameObject.renderer.enabled = false;
		gameObject.collider2D.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (tell);
		if(DoritosStart == true){
			gameObject.renderer.enabled = true;
			gameObject.collider2D.enabled = true;
			GameObject.FindWithTag("DoritosPose").renderer.enabled = false;
			GameObject.FindWithTag("DoritosPose").collider2D.enabled = false;
			Wait();	
			Bricks.finnes = false;
		}
	}
	void Wait(){
			tell+=Time.deltaTime;
			if (tell >= 19f ) {
			gameObject.renderer.enabled = false;
			gameObject.collider2D.enabled = false;
			GameObject.FindWithTag("DoritosPose").renderer.enabled = true;
			GameObject.FindWithTag("DoritosPose").collider2D.enabled = true;
			Bricks.finnes = false;
		}
	}
}
