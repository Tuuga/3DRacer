﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	GameObject[] allNPCs;
	public float avoidanceDistance;
	public float timeScale;

	void Start () {
		allNPCs = GameObject.FindGameObjectsWithTag("NPC");
		print(allNPCs.Length + " NPCs");
	}

	void FixedUpdate () {

		Time.timeScale = timeScale;

		for (int i = 0; i < allNPCs.Length; i++) {
			for (int j = 0; j < allNPCs.Length; j++) {
				if (allNPCs[i].gameObject != allNPCs[j].gameObject) {
					if (Vector3.Distance(allNPCs[i].transform.position, allNPCs[j].transform.position) < avoidanceDistance || allNPCs[i].GetComponent<NPCController>().deltaSpeed < 0.01f) {
						allNPCs[i].GetComponent<NavMeshObstacle>().enabled = true;
						allNPCs[j].GetComponent<NavMeshObstacle>().enabled = true;

					} else {
						allNPCs[i].GetComponent<NavMeshObstacle>().enabled = false;
					}
				}
			}			
		}
	}
}