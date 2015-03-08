using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {
	
	public KeyCode space;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(space)){
			Application.LoadLevel("TitleScreenScene");
		}
	}
}
