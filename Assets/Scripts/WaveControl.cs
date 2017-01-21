using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour {
	private int upCount;
	private int downCount;
	private float waveHeight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		checkCounts ();
	}

	public void commandUP(){
		upCount += 1;
		//waveHeight = waveHeight + (waveHeight * .03);
	}

	public void commandDown(){
		downCount += 1;
	}

	public void checkCounts(){
		if(upCount >= 3){
			RaiseWave ();
		}
		if (downCount >= 3) {
			LowerWave ();
		}

	}

	public void RaiseWave(){
		waveHeight += 5;
		print (waveHeight);

	}

	public void LowerWave(){
		waveHeight -= 5;
		print (waveHeight);
	}
}
