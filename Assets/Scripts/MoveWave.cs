using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MoveWaves
{
	public static void TransformWaves(Transform wave, float interval, AudioSource audio)
	{
		// -= (wave.position.y * interval);
		audio.Play();
		wave.position = new Vector2(0, (wave.position.y * interval));
	}


}
