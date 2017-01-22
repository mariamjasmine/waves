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
	[SerializeField]
	private float killDelay;
	private float timer = 0;
	public GameObject twitchClient;

	void Start ()
	{
		alive = false;
		StartCoroutine ("MakeObstacles");
	}

	void Update ()
	{
		if (alive == false) {
//			timer += Time.deltaTime;
//			if (timer >= killDelay) {
				
//				timer = 0;
//			}
		}
		print ("count: " + count);
		if(count==3){
			alive = false;
			killCreature ();
		}
	}

	IEnumerator MakeObstacles(){
		newTime (); 
		yield return new WaitForSeconds (waitTime);
		currentObstacle = obstacleSprites [Random.Range(0, 4)];
		currentObstacle = Instantiate(currentObstacle,new Vector3(Random.Range(-5,7), -3 , 0),transform.rotation) as GameObject; 
		MoveWaves.TransformWaves(wave, -.06f,upSound);
		alive = true;
		print ("obstacle made");
	}

	public void increaseCount(){
		if (alive == true){
			count += 1;
			print ("increasing count");
		}
	}

	public void killCreature(){
			count = 0;
			Destroy (currentObstacle);
			twitchClient.GetComponent<TwitchIRC>().SendMsg ("Shoe has left. But she will be back");
			StartCoroutine ("MakeObstacles");
	}

	public void newTime(){
		waitTime = Random.Range (2, 10);
	//	print ("Wait Time" + waitTime);

	}
		

}
