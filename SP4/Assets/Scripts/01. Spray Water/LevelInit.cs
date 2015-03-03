using UnityEngine;
using System.Collections;

public class LevelInit : MonoBehaviour {
	
	public Transform firePrefab;
	static public int noFireObj = 0;

	public AudioClip winSound;
	public AudioClip loseSound;

	GameObject Timer;
	
	private float difficulty = GlobalVariables.levelsPlayed * 0.5f;
	
	// Use this for initialization
	void Start () {
		if(difficulty > 4.0f)
		{
			difficulty = 4.0f;
		}
		GlobalVariables.lastLevel = Application.loadedLevel;
		Timer = GameObject.FindGameObjectWithTag("timer");

		for (int i = 0; i < 1 + (int)difficulty; ++i)
		{
			Instantiate(firePrefab, new Vector3(Random.Range(-2.0f, 8.0f), Random.Range(-5.0f, 3.0f), 0), Quaternion.identity);
			noFireObj += 1;
		}
	}
		
	// Update is called once per frame
	void Update () {
		
		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
		{
			if (noFireObj > 0){
				StartCoroutine (Lose());
			}
		}

		if(noFireObj <= 0)
		{
			StartCoroutine(Win());
		}
	}
	

	private IEnumerator Win()
	{
		GlobalVariables.levelPassed = true;
		TimerScript.running = false;
		if (!audio.isPlaying) {
			audio.clip = winSound;
			audio.Play();
		}
		yield return new WaitForSeconds (winSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}

	private IEnumerator Lose()
	{
		GlobalVariables.levelPassed = false;
		if (!audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play();
		}
		yield return new WaitForSeconds (loseSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}
}