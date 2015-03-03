using UnityEngine;
using System.Collections;

public class Beginning : MonoBehaviour 
{
	static bool TapStart = false;

	// Use this for initialization
	void Start () 
	{
		if (!TapStart) 
		{
			GetComponent<SpriteRenderer>().enabled = true;
			Time.timeScale = 0;
		}
		TapStart = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ( Time.timeScale ==0 && (Input.GetMouseButtonDown (0)))
		{
			Time.timeScale = 1;
			GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
