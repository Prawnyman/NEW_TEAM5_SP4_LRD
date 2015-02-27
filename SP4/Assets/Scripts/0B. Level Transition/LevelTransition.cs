using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {
	int nextLevel;

	// Use this for initialization
	void Start () {
		GlobalVariables.levelsPlayed++;
		nextLevel = UnityEngine.Random.Range (3, Application.levelCount);
		while (nextLevel == GlobalVariables.lastLevel) {
			nextLevel = UnityEngine.Random.Range (3, Application.levelCount);
		}
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (NextLevel());
	}


	private IEnumerator NextLevel() {
		yield return new WaitForSeconds (2.0f);
		if (GlobalVariables.lives > 0)
			Application.LoadLevel (nextLevel);
		else
			Application.LoadLevel ("0C. Game Over");
	}
}
