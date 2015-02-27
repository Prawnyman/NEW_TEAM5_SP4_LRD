using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	static public int finalScore;
	//int nextLevel = 0;

	void Start() {
		//GlobalVariables.levelsPlayed++;
		finalScore = GlobalVariables.score + 100;
		/*
		nextLevel = UnityEngine.Random.Range (2, Application.levelCount);
		while (nextLevel == GlobalVariables.lastLevel) {
			nextLevel = UnityEngine.Random.Range (2, Application.levelCount);
		}
		*/
	}

	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + GlobalVariables.score;
		if (GlobalVariables.levelPassed == true)
		{
			if (GlobalVariables.score < finalScore)
				GlobalVariables.score += 2;
			/*else
				StartCoroutine (NextLevel());*/
		}
	}
	/*
	static public IEnumerator NextLevel() {
		yield return new WaitForSeconds (0.8f);
		Application.LoadLevel (nextLevel);
	}*/
}
