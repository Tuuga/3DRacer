﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Debug : MonoBehaviour {

	public Text debugText;
	public Text lapText;
	int lap;
	Vector3 playerStartPos;
	GameObject player;
	Rigidbody rb;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		playerStartPos = player.transform.position;
		rb = player.GetComponent<Rigidbody>();
	}

	void Update () {
		
	}

	public void Reset () {
		player.transform.position = playerStartPos;
		player.transform.rotation = Quaternion.Euler(Vector3.zero);
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
	}

	void TextUpdate () {
		
	}

	void LapCounter () {
		lap++;
		lapText.text = "Lap " + lap;
	}

	/*
	void OnTriggerEnter (Collider c) {
		if (c.transform.parent.tag == "Player" || c.transform.parent.tag == "NPC") {
			LapCounter();
		}
	}
	*/
}
