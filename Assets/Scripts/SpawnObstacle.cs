using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {
	public GameObject obstaclePrefab;
	public Bounds[] bounds;
	public GameObject[] obstacleSprites;
	public float minY, maxY, minX, maxX;
	private GameObject currentObstacle;
	private int count;
	private bool alive;
	private int waitTime;

	public GameObject wave;
	public Vector2 waveCoordinates;
	//public Vector2 waveDimensions;
	private Vector2 maxWaveDimensions;
	private Vector2 minWaveDimensions;
	private float waveHeight;
	public AudioSource upSound;

	void Start ()
	{
		alive = false;
		waveCoordinates = wave.GetComponent<Transform>().position;
		maxWaveDimensions = wave.GetComponent<Renderer> ().bounds.max;
		minWaveDimensions = wave.GetComponent<Renderer> ().bounds.min;
		waveHeight = wave.GetComponent<Transform> ().position.y;
	}

	void Update ()
	{
		if(alive == false){
			StartCoroutine ("MakeObstacles");
		}

	
	}


	IEnumerator MakeObstacles(){
			alive = true;
			newTime ();
			yield return new WaitForSeconds (waitTime);
			currentObstacle = obstacleSprites [Random.Range(0, 3)];
			print (currentObstacle);
			
			currentObstacle = Instantiate(currentObstacle,new Vector3(Random.Range(-5,7), -3 , 0),transform.rotation) as GameObject; 
			waveHeight -= (waveHeight * 0.2f);	
			print (waveHeight);
			upSound.Play();
			wave.transform.position = new Vector2(0, waveHeight);
	}

	public void increaseCount(){
		count += 1;
		if(count==3){
			killCreature ();
		}
	}

	public void killCreature(){
		
			Destroy (currentObstacle);
			alive = false;

	}

	public void newTime(){
		waitTime = Random.Range (2, 10);
		print ("Wait Time" + waitTime);

	}

}
