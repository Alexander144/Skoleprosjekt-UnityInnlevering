﻿using UnityEngine;
using System.Collections;

public class Lyd : MonoBehaviour {
	public AudioClip hitmark;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D (Collision2D Info) {
		if (Info.collider.tag == "Ball") {
			AudioSource.PlayClipAtPoint(hitmark,transform.position);
		}
	}
}