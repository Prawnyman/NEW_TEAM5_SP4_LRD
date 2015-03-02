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
		GlobalVariables.levelPassed = false;
		if (!audio.isPlaying) {
			audio.clip = loseSound;
			audio.Play();
		}
		yield return new WaitForSeconds (loseSound.length);
		Application.LoadLevel ("0B. Level Transition");
	}

	void CreateQuestion (int question)
	{
		GUIStyle questionStyle = new GUIStyle();
		questionStyle.font = myFont;
		questionStyle.alignment = TextAnchor.MiddleCenter;
		questionStyle.normal.textColor = Color.red;
		
		GUIStyle buttonStyle = new GUIStyle();
		buttonStyle.font = myFont;
		buttonStyle.alignment = TextAnchor.MiddleCenter;
		buttonStyle.normal.textColor = Color.white;

		switch (question)
		{
		case 1:
		default:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "When did Singapore become independent?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. 9 March 1954"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. 3 April 1984"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. 9 August 1965"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. 16 November 1975"))
				StartCoroutine(Lose());
			break;

		case 2:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What does Singapore mean?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. Garden City"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Lion City"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Freetown"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Yengema"))
				StartCoroutine(Lose());
			break;

		case 3:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "Which is the currency of Singapore?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. Dollar"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Lats"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Pound"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Baht"))
				StartCoroutine(Lose());
			break;

		case 4:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What is the symbolism of crescent on Singapore's flag?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. Growth of a young country"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Islam"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Hinduism"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Judaism"))
				StartCoroutine(Lose());
			break;

		case 5:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "Who was Singapore's first Prime Minister?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. Tony Tan"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Goh Chok Tong"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Lee Kuan Yew"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Ong Teng Cheongi"))
				StartCoroutine(Lose());
			break;

		case 6:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "Who is the current Prime Minister?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. Tony Tan"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Goh Chok Tong"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Lee Kuan Yew"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Lee Hsien Loong"))
				StartCoroutine(Win());
			break;

		case 7:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What are the 3 main races of Singapore?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. Caucasian, Chinese, Malay"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Malay, Indian, Caucasian"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Chinese, Malay, Korean"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Chinese, Malay, Indian"))
				StartCoroutine(Win());
			break;

		case 8:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "When is the National Day of Singapore?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. 29th April"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. 23rd March"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. 9th August"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. 8th August"))
				StartCoroutine(Lose());
			break;

		case 9:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "How old will Singapore be in 2019?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. 50"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. 54"))
				StartCoroutine(Win());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. 55"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. 53"))
				StartCoroutine(Lose());
			break;

		case 10:
			GUI.TextArea(new Rect(startX, Screen.height * 0.05f, btn_length, btn_height), "What is Singapore's national language?", questionStyle);
			
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.0f, btn_length, btn_height), "A. English"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.2f, btn_length, btn_height), "B. Mandarin"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.4f, btn_length, btn_height), "C. Tamil"))
				StartCoroutine(Lose());
			if (GUI.Button(new Rect(startX, startY + Screen.height * 0.6f, btn_length, btn_height), "D. Malay"))
				StartCoroutine(Win());
			break;
		}
	}

}