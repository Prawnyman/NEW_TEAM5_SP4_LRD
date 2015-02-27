using UnityEngine;
using System.Collections;

public class PlayButtonAlpha : MonoBehaviour {
	
	static public bool startAlpha = false;
	Color newCol;
	
	// Use this for initialization
	void Start () {
		newCol = this.renderer.material.color;
		newCol.a = 0;
		this.renderer.material.color = newCol;
	}
	
	// Update is called once per frame
	void Update () {
		if (startAlpha && newCol.a < 1)
		{
			newCol.a += 0.02f;
			this.renderer.material.color = newCol;
		}
	}
}