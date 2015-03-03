using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	static public int finalScore;
	//int nextLevel = 0;

	void Start() {
		//GlobalVariables.levelsPlayed++;
		finalScore = GlobalVariables.score + 100;
		if (GlobalVariables.levelPassed == true && GlobalVariables.questionLevel == true && GlobalVariables.lives == 5)
			finalScore = GlobalVariables.score + 500;
	}

	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + GlobalVariables.score;
		if (GlobalVariables.levelPassed == true && GlobalVariables.questionLevel == true && GlobalVariables.lives == 5)
		{
			if (GlobalVariables.score < finalScore)
				GlobalVariables.score += 10;
		}
		else if (GlobalVariables.levelPassed == true)
		{
			if (GlobalVariables.score < finalScore)
				GlobalVariables.score += 2;
		} 
	}
}
