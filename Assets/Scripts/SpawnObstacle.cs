using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {
	public GameObject obstaclePrefab;
	public Bounds[] bounds;
	public GameObject[] obstacleSprites;
	public float minY, maxY, minX, maxX;

	public GameObject wave;
	public Vector2 waveCoordinates;
	//public Vector2 waveDimensions;
	private Vector2 maxWaveDimensions;
	private Vector2 minWaveDimensions;

	void Start ()
	{
		
		MakeObstacles ();
		waveCoordinates = wave.GetComponent<Transform>().position;
		maxWaveDimensions = wave.GetComponent<Renderer> ().bounds.max;
		minWaveDimensions = wave.GetComponent<Renderer> ().bounds.min;
		print ("Max" + maxWaveDimensions);
		print ("Min" + minWaveDimensions);
		//print (waveCoordinates);
		//waveDimensions = wave.GetComponent<Renderer>().bounds.size;
		//print (waveDimensions);
	}

	void Update ()
	{


	
	}


	IEnumerator MakeObstacles(){
		GameObject obstacleSprite = obstacleSprites [Random.Range(0, 3)];
		string obstacleName = obstacleSprite.name;
		obstacleSprite = Instantiate(obstacleSprite,new Vector3(Random.Range(0,7),Random.Range(minY,maxY), 0),transform.rotation) as GameObject; 
		if(obstacleSprites != null){
			print ("theres none");
		}

	}

//	public void MakeObstacles(){
//		minX = waveCoordinates[0];
//		minY = waveCoordinates[1];
//	//	maxX = waveCoordinates[0] + waveDimensions[0];
//	//	maxY = waveCoordinates[1] + waveDimensions[1];
//		print (maxX);
//		print (maxY);
//
//		//minY = wavesY, maxY = wavesY + height, minX = wavesX, maxX = wavesX + width
//		GameObject obstacleSprite = obstacleSprites [Random.Range(0, 3)];
//		string obstacleName = obstacleSprite.name;
//
//			//GameObject newObstacle = Instantiate(obstacleSprites[i],  new Vector3(-686, 0, 0), transform.rotation);
//
//		obstacleSprite = Instantiate(obstacleSprite,new Vector3(Random.Range(0,7),Random.Range(minY,maxY), 0),transform.rotation) as GameObject; 
//
//
//	}


}
