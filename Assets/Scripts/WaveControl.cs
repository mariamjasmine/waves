using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveControl : MonoBehaviour {
	private int upCount;
	private int downCount;
	private float waveHeight;

	// Use this for initialization
	void Start () {
		waveHeight = GetComponent<Transform> ().position.y;
		print (waveHeight);
	}
	
	// Update is called once per frame
	void Update () {
		checkCounts ();
	}

	public void commandUP(){
		upCount += 1;
		waveHeight = waveHeight + (waveHeight * -.03f);
		transform.position = new Vector2(0, waveHeight);
		print (waveHeight);
	}

	public void commandDown(){
		downCount += 1;
		waveHeight = waveHeight - (waveHeight * .03f);
		transform.position = new Vector2(0, waveHeight);
	}

	public void checkCounts(){
		if(upCount >= 15){
			RaiseWave ();
		}
		if (downCount >= 15) {
			LowerWave ();
		}

	}

	public void RaiseWave(){
		//waveHeight += 5;
		print (waveHeight);

	}

	public void LowerWave(){
		//waveHeight -= 5;
		print (waveHeight);
	}
}
