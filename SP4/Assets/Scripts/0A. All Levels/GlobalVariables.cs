using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {

	static public int lives = 5;
	static public bool levelPassed = false;
	static public int score = 0;
	static public int lastLevel = 0;
	static public int levelsPlayed = 0;
	static public bool questionLevel = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	static public void Restart() {
		lives = 5;
		levelPassed = false;
		score = 0;
		lastLevel = 0;
		levelsPlayed = 0;
		questionLevel = false;
	}
}
