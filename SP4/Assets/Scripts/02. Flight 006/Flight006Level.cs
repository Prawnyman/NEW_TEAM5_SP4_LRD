using UnityEngine;
using System.Collections;

public class Flight006Level : MonoBehaviour {
	public GameObject plane;
	public GameObject explosion;
	
	public AudioClip winSound;
	public AudioClip loseSound;

	// Use this for initialization
	void Start () {
		GlobalVariables.lastLevel = Application.loadedLevel;
		GameObject obj = Instantiate(plane) as GameObject;
		obj.transform.position.Set(-7, 2.4f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject checkPlane = GameObject.FindGameObjectWithTag("Plane");

		if(checkPlane != null){
			if(checkPlane.GetComponent<PlaneScript>().getTouchedGround()){
				//Plane crashes
				if(checkPlane.GetComponent<PlaneScript>().getRotation() < -7.5f ||
				   checkPlane.GetComponent<PlaneScript>().getRotation() > 7.5f){
					//Lose
					GameObject obj = Instantiate(explosion, checkPlane.transform.position, Quaternion.identity) as GameObject;
					obj.tag = "";
					DestroyObject(checkPlane);
					//audio.Play();
					StartCoroutine (Lose());
				}
				//Plane lands safely
				else{
					//Win
					checkPlane.GetComponent<PlaneScript>().landPlane();
					//Win();
					StartCoroutine (Win());
				}
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
		yield return new WaitForSeconds (1.2f);
		Application.LoadLevel ("0B. Level Transition");
	}
}
