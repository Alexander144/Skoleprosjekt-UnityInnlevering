using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {
	
	public int lives = 3;
	public int bricks = 68;
	public Text livesText;
	public Text bricksText;
	public static GM instance = null;
	public GameObject Hitmarker;

	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	void checkGameOver() {
		if (lives == -1)
			;
		if (bricks == 0)
			bricksText.text = "Bricks right: 420";
	}
	
	public void LoseLife() {
		lives--;
		livesText.text = "Lives: " + lives;
		checkGameOver();
	}
	
	public void DestroyBrick() {
		bricks--;
		bricksText.text = "Bricks left: " + bricks;
		checkGameOver();
	}

	// Update is called once per frame
	void Update () {
	}

}