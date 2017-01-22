using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCreature : MonoBehaviour {
	private GameObject currentObstacle;
	private int count;


	// Use this for initialization
	void Start () {
		//currentObstacle = GameObject.FindGameObjectWithTag ("Obstacle");
		//print (currentObstacle);
	}
	
	// Update is called once per frame
	void Update () {
		currentObstacle = GameObject.FindGameObjectWithTag ("Obstacle");
	}

	public void increaseCount(){
		count += 1;
		if(count==3){
			killCreature ();
		}
	}

	public void killCreature(){
		if (currentObstacle != null) {
			Destroy (currentObstacle);
		//	print ("There's something here!");
		} else {
			print ("nada");
		}

	}
}
