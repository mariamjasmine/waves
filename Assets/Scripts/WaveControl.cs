using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour {
	private int upCount = 0;
	private int downCount = 0;
	private float waveHeight;
	public AudioSource upSound;
	public AudioSource downSound;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		checkCounts ();
	}


	public void commandDown(){
		downCount += 1;
		print(upCount);
	}

	public void commandUp(){
		upCount += 1;
		print (downCount);

	}
		

	public void checkCounts(){
		if(upCount >= 5){
			MoveWaves.TransformWaves(this.transform, -0.1f,upSound);
			upCount = 0;
			downCount = 0;
		}
		if (downCount >= 5) {
			MoveWaves.TransformWaves(this.transform, 0.1f,downSound);
			upCount = 0;
			downCount = 0;
		}

	}

}
