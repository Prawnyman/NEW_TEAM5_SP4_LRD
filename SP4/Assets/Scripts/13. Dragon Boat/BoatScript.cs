﻿using UnityEngine;
using System.Collections;

public class BoatScript : MonoBehaviour {
	
	private Vector3 speed = new Vector3(0.0f, 0, 0);
	private float maxSpeed = 2.5f;
	private Vector3 fp;
	private Vector3 lp;
	
	private float timeLastRowed = -1.0f;
	
	private float yChange = 0.0f;
	
	private enum row
	{
		Left,
		Right,
	};
	
	row currentRow;
	
	public GameObject arrow;
	
	// Use this for initialization
	void Start () {
		currentRow = row.Left;
	}
	
	void Win(){}
	void Lose(){}
	
	// Update is called once per frame
	void Update () {
		float currentTime = Time.time;
		
		transform.position += speed * Time.deltaTime;

		if(!GlobalVariables.gamePaused){
			if(speed.x > 0)
			{
				speed.x -= 0.03f;
			}
			
			if(speed.x < 0)
			{
				speed.x = 0;
			}
			
			//arrow update
			if(currentRow == row.Left)
			{
				arrow.transform.position = new Vector3(-5, 0, 0);
			}
			else if(currentRow == row.Right)
			{
				arrow.transform.position = new Vector3(5, 0, 0);
			}
			
			#if UNITY_ANDROID
			if(Input.touches.Length > 0)
			{
				if(Input.touchCount == 1)
				{
					Touch touch = Input.GetTouch(0);
					
					if(touch.phase == TouchPhase.Began)
					{
						fp = touch.position;
						lp = touch.position;
					}
					if(touch.phase == TouchPhase.Moved)
					{
						lp = touch.position;
						yChange = lp.y - fp.y;
						fp = touch.position;
					}
					if(touch.phase == TouchPhase.Ended && currentRow == row.Left)
					{
						if(yChange < -50 && fp.x < Screen.width / 2 && lp.x < Screen.width / 2)
						{
							if(currentTime - timeLastRowed > 0.15f){
								speed.x = maxSpeed;
							}
							else{
								speed.x  = speed.x * 0.75f;
							}
							
							timeLastRowed = currentTime;
							currentRow = row.Right;
							arrowScript.color.a = 1;
						}
					}
					if(touch.phase == TouchPhase.Ended && currentRow == row.Right)
					{
						if(yChange < -50 && fp.x > Screen.width / 2 && lp.x > Screen.width / 2)
						{
							if(currentTime - timeLastRowed > 0.15f){
								speed.x = maxSpeed;
							}
							else{
								speed.x = speed.x * 0.75f;
							}
							
							timeLastRowed = currentTime;
							currentRow = row.Left;
							arrowScript.color.a = 1;
						}
						
						audio.Play();
						
					}
				}
			}
			#endif
			
			#if UNITY_EDITOR
			if(Input.GetKeyDown("left"))
			{
				if(currentRow == row.Left)
				{
					if(currentTime - timeLastRowed > 0.15f){
						speed.x = maxSpeed;
					}
					else{
						speed.x = speed.x * 0.75f;
					}	
					
					timeLastRowed = currentTime;
					currentRow = row.Right;
					arrowScript.color.a = 1;
				}
				audio.Play();
			}
			else if(Input.GetKeyDown("right"))
			{
				if(currentRow == row.Right && currentTime - timeLastRowed > 0.5f)
				{
					if(currentTime - timeLastRowed > 0.15f){
						speed.x = maxSpeed;
					}
					else{
						speed.x = speed.x * 0.75f;
					}
					
					timeLastRowed = currentTime;
					currentRow = row.Left;
					arrowScript.color.a = 1;
				}
				audio.Play();
			}
			#endif
		}
	}
}