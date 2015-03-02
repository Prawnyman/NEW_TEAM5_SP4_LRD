using UnityEngine;
using System.Collections;

public class MainCameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalVariables.soundEnabled && AudioListener.volume < 1.0f){
			AudioListener.volume = 1.0f;
		}
		else if(!GlobalVariables.soundEnabled && AudioListener.volume > 0.0f){
			AudioListener.volume = 0.0f;
		}
	}
}
