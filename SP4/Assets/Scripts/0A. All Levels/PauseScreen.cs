using System;
using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class PauseScreen : MonoBehaviour {

	public Texture tex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touches.Length > 0 || Input.GetMouseButton(0)){
			Time.timeScale = 1.0f;
			GlobalVariables.gamePaused = false;
			DestroyObject(gameObject);
		}
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), tex);
	}
}
