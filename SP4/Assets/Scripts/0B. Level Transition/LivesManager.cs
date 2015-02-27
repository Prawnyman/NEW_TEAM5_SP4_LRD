using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesManager : MonoBehaviour {

	public Object Heart;
	public Object BlackHeart;

	public GameObject[] hearts;

	void Start () {
		for (int i = 0; i < 5; i++)
		{
			GameObject HeartObject = GameObject.Instantiate (Heart) as GameObject;
			int spawnX = -6 + i * 3;
			int spawnY = 1;

			HeartObject.transform.position = new Vector3 (spawnX, spawnY, 0);
			HeartObject.tag = "heart";
			if (i + 1 > GlobalVariables.lives)
				HeartObject.renderer.material.color = Color.black;

		}
		
		if (GlobalVariables.levelPassed == false) {
			GlobalVariables.lives--;
			Debug.Log("Lose " + GlobalVariables.lastLevel);
		}
	}

	void Update () {
		hearts = GameObject.FindGameObjectsWithTag ("heart");

		if (GlobalVariables.levelPassed == false) 
		{
			Vector4 col = hearts[GlobalVariables.lives].renderer.material.color;
			col.x -= 0.02f;
			hearts[GlobalVariables.lives].renderer.material.color = col;
		}
	}
}
