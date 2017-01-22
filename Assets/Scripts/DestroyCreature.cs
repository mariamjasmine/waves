using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCreature : MonoBehaviour {
	private GameObject currentObstacle;


	// Use this for initialization
	void Start () {
		//currentObstacle = GameObject.FindGameObjectWithTag ("Obstacle");
		//print (currentObstacle);
	//	killCreature();
	}
	
	// Update is called once per frame
	void Update () {
		currentObstacle = GameObject.FindGameObjectWithTag ("Obstacle");
	}

	void killCreature(){
		if (currentObstacle != null) {
			print ("There's something here!");
		} else {
			print ("nada");
		}

	}
}
