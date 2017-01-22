using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {
	public GameObject[] obstacleSprites;
	private GameObject currentObstacle;
	public float minY, maxY;
	private int count;
	private bool alive;
	private int waitTime;
	public Transform wave;
	public AudioSource upSound;

	void Start ()
	{
		alive = false;
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
		currentObstacle = obstacleSprites [Random.Range(0, 4)];
		currentObstacle = Instantiate(currentObstacle,new Vector3(Random.Range(-5,7), -3 , 0),transform.rotation) as GameObject; 
		MoveWaves.TransformWaves(wave, .06f,upSound);
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
