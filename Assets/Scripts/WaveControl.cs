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
		waveHeight = GetComponent<Transform> ().position.y;
		print (waveHeight);
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
		print(downCount);


	public void commandUP(){
		upCount += 1;
		waveHeight = waveHeight - (waveHeight * .05f);
		transform.position = new Vector2(0, waveHeight);
		print (waveHeight);
	}

	public void commandDown(){
		downCount += 1;
		waveHeight = waveHeight + (waveHeight * .05f);
		transform.position = new Vector2(0, waveHeight);

	}

	public void checkCounts(){
		if(upCount >= 5){
			RaiseWave ();
			upCount = 0;
			downCount = 0;
		}
		if (downCount >= 5) {
			LowerWave ();
			upCount = 0;
			downCount = 0;
		}

	}

	public void RaiseWave(){
		//waveHeight += 5;
		print (waveHeight);
		waveHeight -= (waveHeight * 0.3f);
		upSound.Play();
		transform.position = new Vector2(0, waveHeight);
	}

	public void LowerWave(){
		//waveHeight -= 5;
		print (waveHeight);
		waveHeight +=  (waveHeight * 0.3f);
		downSound.Play();
		transform.position = new Vector2(0, waveHeight);
	}
}
