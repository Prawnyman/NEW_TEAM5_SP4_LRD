using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScoreScript : MonoBehaviour {
	Vector3 newPos;
	
	void Start() {
		newPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (newPos.y < 0.4) {
			newPos.y += 0.002f;
		}
		else {
			StartCoroutine(AlphaButton());
		}
		this.transform.position = newPos;
		guiText.text = "Score: " + GlobalVariables.score;
	}
	
	static public IEnumerator AlphaButton() {
		yield return new WaitForSeconds (1.0f);
		PlayButtonAlpha.startAlpha = true;
	}
	
	/*
	static public IEnumerator NextLevel() {
		yield return new WaitForSeconds (0.8f);
		Application.LoadLevel (nextLevel);
	}
	 */
}