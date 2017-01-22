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

	public void killCreature(){
		if (currentObstacle != null) {
			currentObstacle.Destroy;
			print ("There's something here!");
		} else {
			print ("nada");
		}

	}
}
