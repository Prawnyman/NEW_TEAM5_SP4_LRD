using UnityEngine;
using System.Collections;

public class RubbleLevel : MonoBehaviour
{
	public GameObject Rock;
	public GameObject Picture;
	public GameObject Picture2;
	public AudioClip winSound;
	public AudioClip loseSound;
	GameObject Timer;
	private bool gameEnd = true;
	private float x = 0;
	private float y = 0;
	private float difficulty = GlobalVariables.levelsPlayed;
	// Use this for initialization
	void Start ()
	{
		GlobalVariables.lastLevel = Application.loadedLevel;
		Timer = GameObject.FindGameObjectWithTag ("timer");

		int z = 0;
		float pic = Random.Range (1, 10);
		if (pic < 5) {
			Instantiate (Picture);
		} else {
			Instantiate (Picture2);
		}
		if ((int)difficulty < 3) {
			for (int i =0; i<=3; i++) {
				x = Random.Range (-7, 7);
				y = Random.Range (-4, 4);
				Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
				z++;
			}
		} 
		for (int i =0; i<((int)difficulty); i++) {
			if( i <6)
			{
			x = Random.Range (-7, 7);
			y = Random.Range (-4, 4);
			Instantiate (Rock, new Vector3 (x, y, z), Quaternion.identity);
			z++;
			}
		}



	}

	
	// Update is called once per frame
	void Update ()
	{
		GameObject checkRubble = GameObject.FindGameObjectWithTag ("Rock");

		if (Timer.GetComponent<TimerScript> ().timeLeft <= 0) {
			if (checkRubble != null && gameEnd) {
				gameEnd = false;
				StartCoroutine (Lose ());
			}
		} else {
			if (checkRubble == null && gameEnd) {
				gameEnd = false;
				StartCoroutine (Win ());
			}
		}
	}

	private IEnumerator Win ()
	{
		TimerScript.running = false;
		GlobalVariables.levelPassed = true;
		if (!audio.isPlaying) {
			audio.clip = winSound;
			audio.Play ();
		}
		yield return new WaitForSeconds (winSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}
	
	private IEnumerator Lose ()
	{
		GlobalVariables.levelPassed = false;
		if (!audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play ();
		}
		yield return new WaitForSeconds (loseSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}
}
