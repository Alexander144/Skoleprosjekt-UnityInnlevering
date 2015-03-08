using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	
	public KeyCode space;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(space)){
			Application.LoadLevel("ForsteScene");
		}
	}
}
