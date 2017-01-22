using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour {
	private int upCount = 0;
	private int downCount = 0;
	private float waveHeight = -5;
	//sound effects from freesfx.com
	public AudioSource upSound;
	public AudioSource downSound;

	private bool gameOver = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		checkCounts ();
	}


	public void commandDown(){
		downCount += 1;
		//print(downCount);
	}

	public void commandUp(){
		upCount += 1;
		//print (upCount);

	}
		

	public void checkCounts(){
		if(upCount >= 5){
			MoveWaves.TransformWaves(this.transform, -0.1f,upSound);
			upCount = 0;
			downCount = 0;
			waveHeight = this.transform.position.y;
			//print (waveHeight);
		}
		if (downCount >= 5) {
			MoveWaves.TransformWaves(this.transform, 0.1f,downSound);
			upCount = 0;
			downCount = 0;
			waveHeight = this.transform.position.y;
		}

		if(waveHeight > -1.5 || waveHeight < -11){
			//print (waveHeight);
			gameOver = true;
		}
		if (gameOver) {
			failState ();
		}

	}

	public void failState(){
		print ("Game Over");
	}

}

