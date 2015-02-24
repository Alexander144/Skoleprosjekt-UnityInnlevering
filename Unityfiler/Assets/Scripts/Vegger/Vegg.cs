using UnityEngine;
using System.Collections;

public class Vegg : MonoBehaviour {
	// Update is called once per frame
 	public Camera mainCamera = new Camera();

	public Transform topVegg;
	public Transform venstreVegg;
	public Transform hoyereVegg;
	public Transform bunnVegg;
	void Start () {
		topVegg.position = new Vector2 (0f,6.578f);
		topVegg.localScale = new Vector2 (35f, 1f);
		bunnVegg.position = new Vector2 (0f,-6f);
		bunnVegg.localScale = new Vector2 (35f, 1f);
		venstreVegg.position = new Vector2 (-11.81623f,1f);
		venstreVegg.localScale = new Vector2 (1f, 30f);
		hoyereVegg.position = new Vector2 (11.77623f,1f);
		hoyereVegg.localScale = new Vector2 (1f, 30f);
	}
}
