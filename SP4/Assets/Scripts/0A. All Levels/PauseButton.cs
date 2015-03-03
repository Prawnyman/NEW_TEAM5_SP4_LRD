using System;
using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class PauseButton : MonoBehaviour {

	public GameObject pauseScreen;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height*0.95f, 0.0f));
		this.transform.Translate(-this.renderer.bounds.size.x * 0.6f, -this.renderer.bounds.size.y * 0.6f, 10.0f);
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
		if(!GlobalVariables.gamePaused){
			Time.timeScale = 0.0f;
			GlobalVariables.gamePaused = true;

			Instantiate(pauseScreen, new Vector3(0, 0, 0), Quaternion.identity);
		}
	}
}
