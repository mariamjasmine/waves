using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour {
	public GameObject obstaclePrefab;
	public Bounds[] bounds;
	public GameObject[] obstacleSprites;
	public float minY, maxY, minX, maxX;

	void Start ()
	{
		bounds = new Bounds[obstacleSprites.Length];
		for (int i = 0; i < bounds.Length; i++)
		{
			bounds[i] = obstacleSprites[i].GetComponent<BoxCollider2D>().bounds;
		}
		MakeObstacles ();
	}

	void Update ()
	{


	}

	public void MakeObstacles(){
		for (int i = 0; i < obstacleSprites.Length; i++) {
			GameObject obstacleSprite = obstacleSprites [i];
			string obstacleName = obstacleSprite.name;

			GameObject newObstacle = Instantiate(obstacleSprites[i],  new Vector3(-686, 0, 0), transform.rotation);

			obstacleSprites[i]=Instantiate(obstacleSprites[i],new Vector3(Random.Range(minY,maxY),Random.Range(minX,maxX), 0),transform.rotation) as GameObject; 

		}
	}

	//	bool hasCollisions(GameObject target)
	//	{
	//		for (int j = 0; j < hatSprites.Length; j++)
	//		{
	//			if (target.GetComponent<BoxCollider>().bounds.Intersects(bound[j]))
	//			{
	//				return true;
	//			}
	//
	//		}
	//		return false;
	//	}
}
