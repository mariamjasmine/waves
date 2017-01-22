using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {
	public GameObject[] obstacleSprites;
	private GameObject currentObstacle;
	public float minY, maxY;
	private int enemyCount;
	private int washCount;
	private bool alive;
	private int waitTime;
	public Transform wave;
	public AudioSource upSound;
	public GameObject twitchClient;
	private string killMessage;

	void Start ()
	{
		alive = false;
		StartCoroutine ("MakeObstacles");
	}

	void Update ()
	{
		
		//print ("count: " + enemyCount);
		if(enemyCount == 3 && currentObstacle.tag == "creature"){
			alive = false;
			killCreature ();
		}

		if(washCount == 3 && currentObstacle.tag == "product"){
			alive = false;
			washGrammy ();
		}
	}

	IEnumerator MakeObstacles(){
		newTime (); 
		yield return new WaitForSeconds (waitTime);
		currentObstacle = obstacleSprites [Random.Range(0, 8)];
		currentObstacle = Instantiate(currentObstacle,new Vector3(Random.Range(-5,7), -3 , 0),transform.rotation) as GameObject; 
		killMessage = currentObstacle.GetComponent<Obstacle>().chatMessage;
		MoveWaves.TransformWaves(wave, -.06f,upSound);
		alive = true;
		print ("obstacle made");
	}

	public void increaseEnemyCount(){
		if (alive == true && currentObstacle.tag == "creature"){
			enemyCount += 1;
			print ("increasing enemy count");
		}
	}

	public void increaseWashCount(){
		if (alive == true && currentObstacle.tag == "product") {
			washCount += 1;
			print ("increasing wash count");
		}

	}

	public void killCreature(){
			enemyCount = 0;
			Destroy (currentObstacle);
			twitchClient.GetComponent<TwitchIRC>().SendMsg (killMessage);
			StartCoroutine ("MakeObstacles");
	}

	public void washGrammy(){
			washCount = 0;
			Destroy (currentObstacle);
			twitchClient.GetComponent<TwitchIRC>().SendMsg (killMessage);
			StartCoroutine ("MakeObstacles");

	}

	public void newTime(){
		waitTime = Random.Range (2, 10);
	//	print ("Wait Time" + waitTime);

	}
		

}
