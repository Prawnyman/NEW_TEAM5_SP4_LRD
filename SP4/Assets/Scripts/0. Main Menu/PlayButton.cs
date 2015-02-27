using System;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine;

public class PlayButton : MonoBehaviour
{

	public Sprite normal;
	public Sprite down;
	private SpriteRenderer spriteRenderer;
	
	private void OnEnable()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();	
		// subscribe to gesture's Tapped event
		GetComponent<TapGesture>().Tapped += tappedHandler;
		GetComponent<PressGesture>().Pressed += pressedHandler;
		GetComponent<ReleaseGesture>().Released += releasedHandler;
	}
	
	private void OnDisable()
	{
		// don't forget to unsubscribe
		GetComponent<TapGesture>().Tapped -= tappedHandler;
		GetComponent<PressGesture>().Pressed -= pressedHandler;
		GetComponent<ReleaseGesture>().Released -= releasedHandler;
	}

	private void tappedHandler(object sender, EventArgs e)
	{
		//Application.LoadLevel(UnityEngine.Random.Range(1, Application.levelCount));
		Application.LoadLevel(UnityEngine.Random.Range(3, Application.levelCount));
		GlobalVariables.Restart();
	}

	private void pressedHandler(object sender, EventArgs e)
	{
		spriteRenderer.sprite = down;
	}
	
	private void releasedHandler(object sender, EventArgs e)
	{
		spriteRenderer.sprite = normal;
	}
}