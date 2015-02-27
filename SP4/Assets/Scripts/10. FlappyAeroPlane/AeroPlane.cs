using UnityEngine;
using System.Collections;

public class AeroPlane : MonoBehaviour 
{
	public float FlySpeed = 1.0f;
	public Vector2 jumpForce = new Vector2(0, 300);
	//Vector3 velocity = Vector3.zero;


	public AudioClip winSound;
	public AudioClip loseSound;
	
	GameObject Timer;
	
	private bool gameEnd = true;

	// Use this for initialization
	void Start () 
	{
		GlobalVariables.lastLevel = Application.loadedLevel;
		Timer = GameObject.FindGameObjectWithTag("timer");
	}

	// Update is called once per frame
	void Update () 
	{		
		if (gameEnd)
		{
			if (Input.GetKeyUp ("space") || Input.touchCount > 0)
			{
				rigidbody2D.velocity = Vector2.zero;
				rigidbody2D.AddForce (jumpForce);
			}

			Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
			if (screenPosition.y > Screen.height || screenPosition.y < 0)
			{
				//GameOver();
			}	
		}

		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
		{
			if (gameEnd) {
				gameEnd = false;
				StartCoroutine (Win());
			}
		}
	}

	void FixedUpdate()
	{
		if (gameEnd)
			rigidbody2D.AddForce (Vector2.right * FlySpeed);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (gameEnd)
		{
			gameEnd = false;
			StartCoroutine(Lose());
		}
	}

	private IEnumerator Win()
	{
		GlobalVariables.levelPassed = true;
		if (!audio.isPlaying) {
			audio.clip = winSound;
			audio.Play();
		}
		yield return new WaitForSeconds (2.4f);
		Application.LoadLevel ("0B. Level Transition");
	}
	
	private IEnumerator Lose()
	{
		GlobalVariables.levelPassed = false;
		if (!audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play();
		}
		yield return new WaitForSeconds (1.1f);
		Application.LoadLevel ("0B. Level Transition");
	}
}
