using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

	public float timeLeft;
	public float timeMax;
	public Material mat;

	Color sgRed;
	Color sgBase;
	// Use this for initialization
	void Start () {
		timeLeft = timeMax;

		sgRed.r = 240f / 255;
		sgRed.g = 19f / 255;
		sgRed.b = 52f / 255;
		sgRed.a = 1;

		sgBase = sgRed;
		sgBase.a = 0.1f;
	}
	/*
	void DrawQuad(Rect position, Color color) {
		Texture2D texture = new Texture2D(1, 1);
		texture.SetPixel(0,0,color);
		texture.Apply();
		GUI.skin.box.normal.background = texture;
		GUI.Box(position, GUIContent.none);
	}
*/
	void DrawQuad(Rect position, Color color) {
		Texture2D texture = new Texture2D(1, 1);
		texture.SetPixel(0,0,color);
		texture.Apply();
		GUI.skin.box.normal.background = texture;
		GUI.Box(position, GUIContent.none);
	}



	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) {
			timeLeft = 0;
		}
	}

	void OnGUI()
	{
		DrawQuad(new Rect (0, 0, Screen.width, Screen.height * 0.05f), sgBase);
		if (timeLeft > 0) {
			DrawQuad(new Rect (0, 0, Screen.width * (timeLeft / timeMax), Screen.height * 0.05f), sgRed);
		}
	}
}
