	using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {
	int nextLevel;

	// Use this for initialization
	void Start () {
		GlobalVariables.levelsPlayed++;
		nextLevel = UnityEngine.Random.Range (3, Application.levelCount - 1);
		while (nextLevel == GlobalVariables.lastLevel) {
			nextLevel = UnityEngine.Random.Range (3, Application.levelCount - 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (NextLevel());
	}


	private IEnumerator NextLevel() {
		yield return new WaitForSeconds (2.0f);
		if (GlobalVariables.questionLevel == true)
			GlobalVariables.questionLevel = false;
		if (GlobalVariables.lives > 0)
			if (GlobalVariables.levelsPlayed % 5 == 0)
				Application.LoadLevel ("11. The Quiz");
			else
				Application.LoadLevel (nextLevel);
		else
			Application.LoadLevel ("0C. Game Over");
	}
}
