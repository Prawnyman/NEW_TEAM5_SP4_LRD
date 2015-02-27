using UnityEngine;
using System.Collections;

public class InstructionText : MonoBehaviour {
	Color newCol;
	
	// Use this for initialization
	void Start () {
		//guiText.renderer.material.color;
		newCol = guiText.material.color;
		//newCol.a = 0;
		//guiText.material.color = newCol;

	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(Fade());
	}

	private IEnumerator Fade()
	{
		yield return new WaitForSeconds (3.0f);
		if (newCol.a > 0)
		{
			newCol.a -= 0.02f;
			guiText.material.color = newCol;
		}
	}
}
