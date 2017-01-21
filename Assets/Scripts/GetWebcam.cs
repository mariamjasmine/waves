using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWebcam : MonoBehaviour {
	public GUITexture BackgroundTexture;
	private WebCamTexture CameraTexture;

	public void Start(){
		Debug.Log("Initialize");
		BackgroundTexture = gameObject.AddComponent<GUITexture>();
		BackgroundTexture.pixelInset = new Rect(0,0,Screen.width,Screen.height);
		//set up camera
		WebCamDevice[] devices = WebCamTexture.devices;
		string backCamName="";
		/*for( int i = 0 ; i < devices.Length ; i++ ) {
			Debug.Log("Device:"+devices[i].name+ "IS FRONT FACING:"+devices[i].isFrontFacing);

			if (!devices[i].isFrontFacing) {
				backCamName = devices[i].name;
			}
		}*/
		backCamName = devices[1].name;

		CameraTexture = new WebCamTexture(backCamName,500, 500,30);
		CameraTexture.Play();
		BackgroundTexture.texture = CameraTexture;

	}

}
