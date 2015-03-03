using UnityEngine;
using System.Collections;

public class QuizQuestions : MonoBehaviour {

	GameObject Timer;
	public AudioClip winSound;
	public AudioClip loseSound;
	int question;

	float startX;
	float startY;
	float btn_length;
	float btn_height;
	public Font myFont;

	static public bool lose = false;

	GUIStyle questionStyle;
	GUIStyle buttonStyle;
	GUIStyle correctStyle;

	void Start ()
	{
		GlobalVariables.questionLevel = true;
		Timer = GameObject.FindGameObjectWithTag("timer");
		lose = false;

		startX = Screen.width * 0.3f;
		startY = Screen.height * 0.2f;
		btn_length = Screen.width * 0.4f;
		btn_height = Screen.height * 0.1f;
		question = Random.Range(1, 10);

		questionStyle = new GUIStyle();
		questionStyle.font = myFont;
		questionStyle.alignment = TextAnchor.MiddleCenter;
		questionStyle.normal.textColor = Color.red;
		questionStyle.fontSize = 50;
		
		buttonStyle = new GUIStyle();
		buttonStyle.font = myFont;
		buttonStyle.alignment = TextAnchor.MiddleCenter;
		buttonStyle.normal.textColor = Color.red;
		buttonStyle.fontSize = 40;
		
		//correctStyle = new GUIStyle();
	//	correctStyle = buttonStyle;

		correctStyle = new GUIStyle();
		correctStyle.font = myFont;
		correctStyle.alignment = TextAnchor.MiddleCenter;
		correctStyle.normal.textColor = Color.red;
		correctStyle.fontSize = 40;
	}

	void OnGUI() {
		if (Timer.GetComponent<TimerScript>().timeLeft > 0)
			CreateQuestion (question);
	}

	void Update() {
		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
		{
			if (!lose) {
				lose = true;
				StartCoroutine(Lose());
			}
		}
	}

	private IEnumerator Win()
	{
		correctStyle.normal.textColor = Color.green;
		TimerScript.running = false;
		GlobalVariables.levelPassed = true;
		if (!audio.isPlaying) {
			audio.clip = winSound;
			audio.Play();
		}
		yield return new WaitForSeconds (winSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}
	
	private IEnumerator Lose()
	{
		correctStyle.normal.textColor = Color.green;
		TimerScript.running = false;
		GlobalVariables.levelPassed = false;
		if (!audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play();
		}
		yield return new WaitForSeconds (loseSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}

	void DrawRectangle(int x, int y, int l, int b)
	{

	}

	void CreateQuestion (int question)
	{
		if(!GlobalVariables.gamePaused){
			switch (question)
			{
			case 1:
			default:
				GUI.TextArea(new Rect(startX, Screen.height * 0.2f, btn_length, btn_height), "When did Singapore become independent?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. 9 March 1954", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. 3 April 1984", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. 9 August 1965", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. 16 November 1975", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 2:
				GUI.TextArea(new Rect(startX, Screen.height * 0.2f, btn_length, btn_height), "What does Singapore mean?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. Garden City", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Lion City", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Freetown", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Yengema", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 3:
				GUI.TextArea(new Rect(startX, Screen.height * 0.2f, btn_length, btn_height), "Which is the currency of Singapore?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. Dollar", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Lats", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Pound", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Baht", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 4:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What is the symbolism of crescent on Singapore's flag?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. Growth of a young country", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Islam", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Hinduism", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Judaism", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 5:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "Who was Singapore's first Prime Minister?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. Tony Tan", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Goh Chok Tong", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Lee Kuan Yew", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Ong Teng Cheong", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 6:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "Who is the current Prime Minister?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. Tony Tan", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Goh Chok Tong", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Lee Kuan Yew", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Lee Hsien Loong", correctStyle))
					StartCoroutine(Win());
				break;
				
			case 7:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What are the 3 main races of Singapore?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. Caucasian, Chinese, Malay", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Malay, Indian, Caucasian", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Chinese, Malay, Korean", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Chinese, Malay, Indian", correctStyle))
					StartCoroutine(Win());
				break;
				
			case 8:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "When is the National Day of Singapore?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. 29th April", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. 23rd March", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. 9th August", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. 8th August", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 9:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "How old will Singapore be in 2019?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. 50", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. 54", correctStyle))
					StartCoroutine(Win());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. 55", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. 53", buttonStyle))
					StartCoroutine(Lose());
				break;
				
			case 10:
				GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What is Singapore's national language?", questionStyle);
				
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "A. English", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.3f, btn_length, btn_height), "B. Mandarin", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX - Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "C. Tamil", buttonStyle))
					StartCoroutine(Lose());
				if (GUI.Button(new Rect(startX + Screen.width * 0.25f, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Malay", correctStyle))
					StartCoroutine(Win());
				break;
			}
		}
	}

}