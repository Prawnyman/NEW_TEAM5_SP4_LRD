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
	
	}
	
	private void OnEnable()
	{
		// subscribe to gesture's Tapped event
		GetComponent<TapGesture>().Tapped += tappedHandler;
	}
	
	private void OnDisable()
	{
		// don't forget to unsubscribe
		GetComponent<TapGesture>().Tapped -= tappedHandler;
	}
	
	private void tappedHandler(object sender, EventArgs e)
	{
		Time.timeScale = 1.0f;
		GlobalVariables.gamePaused = false;
		DestroyObject(gameObject);
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), tex);
	}
}
