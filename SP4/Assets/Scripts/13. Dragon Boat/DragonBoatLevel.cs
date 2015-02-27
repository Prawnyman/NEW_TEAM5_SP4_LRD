using UnityEngine;
using System.Collections;

public class DragonBoatLevel : MonoBehaviour {
	public AudioClip winSound;
	public AudioClip loseSound;
	
	GameObject Timer;
	GameObject Boat;

	private bool gameEnd = true;

	// Use this for initialization
	void Start () {
		GlobalVariables.lastLevel = Application.loadedLevel;
		Timer = GameObject.FindGameObjectWithTag("timer");
		Boat = GameObject.FindGameObjectWithTag("Boat");
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer.GetComponent<TimerScript>().timeLeft <= 0) {
			if (Boat.transform.position.x < 20 && gameEnd)
			{
				gameEnd = false;
				StartCoroutine(Lose ());
			}
		}
		else {
			if (Boat.transform.position.x >= 20)
			{
				gameEnd = false;
				StartCoroutine(Win ());
			}
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
