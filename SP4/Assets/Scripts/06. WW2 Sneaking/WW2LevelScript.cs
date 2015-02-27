using UnityEngine;
using System.Collections;

public class WW2LevelScript : MonoBehaviour {
	public GameObject character;
	public GameObject guard;

	private GameObject theCharacter;

	public AudioClip winSound;
	public AudioClip loseSound;

	private bool gameEnd = true;

	// Use this for initialization
	void Start () {
		GlobalVariables.lastLevel = Application.loadedLevel;

		//Create character
		GameObject newCharacter = Instantiate(character, new Vector3(-8.2f, 0, 0), Quaternion.identity) as GameObject;
		newCharacter.tag = "Character";
		theCharacter = newCharacter;

		//Create guards
		GameObject newGuard = Instantiate(guard, new Vector3(-4.8f, -4, 0), Quaternion.identity) as GameObject;
		newGuard.GetComponent<WW2GuardScript>().setDir(0, 1);

		newGuard = Instantiate(guard, new Vector3(0, 4, 0), Quaternion.identity) as GameObject;
		newGuard.GetComponent<WW2GuardScript>().setDir(0, -1);

		newGuard = Instantiate(guard, new Vector3(4.8f, -4, 0), Quaternion.identity) as GameObject;
		newGuard.GetComponent<WW2GuardScript>().setDir(0, 1);
	}
	
	// Update is called once per frame
	void Update () {

		//Checks if player has reached endpoint
		if(theCharacter.GetComponent<WW2CharacterScript>().getReachedEndpoint() && gameEnd){
			gameEnd = false;
			StartCoroutine(Win());
		}
		else if(theCharacter.GetComponent<WW2CharacterScript>().getCaughtByGuards() && gameEnd){
			gameEnd = false;
			StartCoroutine(Lose());
		}
	}

	private IEnumerator Win()
	{
		GlobalVariables.levelPassed = true;
		if (!this.audio.isPlaying) {
			audio.clip = winSound;
			audio.Play();
		}
		yield return new WaitForSeconds (2.4f);
		Application.LoadLevel ("0B. Level Transition");
	}
	
	private IEnumerator Lose()
	{
		GlobalVariables.levelPassed = false;
		if (!this.audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play();
		}
		yield return new WaitForSeconds (0.8f);
		Application.LoadLevel ("0B. Level Transition");
	}
}
