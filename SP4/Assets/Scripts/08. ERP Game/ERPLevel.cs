using UnityEngine;
using System.Collections;

public class ERPLevel : MonoBehaviour
{
	public AudioClip winSound;
	public AudioClip loseSound;

	static public bool lose = false;

	GameObject Timer;
	
	void Start() {
		GlobalVariables.lastLevel = Application.loadedLevel;
		Timer = GameObject.FindGameObjectWithTag("timer");
		lose = false;
	}

	void Update () {
		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
		{
			if (!lose)
				StartCoroutine(Win());
		}
		if (lose)
		{
			lose = false;
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
		yield return new WaitForSeconds (winSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}
	
	private IEnumerator Lose()
	{
		TimerScript.running = false;
		GlobalVariables.levelPassed = false;
		if (!audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play();
		}
		yield return new WaitForSeconds (loseSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}
}