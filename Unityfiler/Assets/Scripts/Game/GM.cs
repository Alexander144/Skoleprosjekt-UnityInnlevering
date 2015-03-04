using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {
	
	public int lives = 3;
	public int bricks = 68;
	public Text livesText;
	public static GM instance = null;
	public GameObject Hitmarker;
	public GameObject LivesText;
	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void LoseLife() {
		lives--;
	}
	
	public void DestroyBrick() {
		bricks--;
	}
}