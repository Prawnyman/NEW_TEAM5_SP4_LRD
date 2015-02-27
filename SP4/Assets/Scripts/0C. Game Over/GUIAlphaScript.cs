using UnityEngine;
using System.Collections;

public class GUIAlphaScript : MonoBehaviour {
	
	Color newCol;
	
	// Use this for initialization
	void Start () {
		//guiText.renderer.material.color;
		newCol = guiText.material.color;
		newCol.a = 0;
		guiText.material.color = newCol;
	}
	
	// Update is called once per frame
	void Update () {
		if (newCol.a < 1)
		{
			newCol.a += 0.02f;
			guiText.material.color = newCol;
		}
	}
}