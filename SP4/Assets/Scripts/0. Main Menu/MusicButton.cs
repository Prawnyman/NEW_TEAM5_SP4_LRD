using System;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine;

public class MusicButton : MonoBehaviour {

	public Sprite music_enabled;
	public Sprite music_disabled;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();

		if(GlobalVariables.soundEnabled)
			spriteRenderer.sprite = music_enabled;
		else
			spriteRenderer.sprite = music_disabled;
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
		GlobalVariables.soundEnabled = !GlobalVariables.soundEnabled;
		
		if(GlobalVariables.soundEnabled)
			spriteRenderer.sprite = music_enabled;
		else
			spriteRenderer.sprite = music_disabled;
	}
}
