using UnityEngine;
using System.Collections;

public class arrowScript : MonoBehaviour {
	
	public GameObject arrow;
	Color color;
	
	private bool changeA = false;
	
	// Use this for initialization
	void Start () {
		color = arrow.renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (color.a >= 1.0f){
			changeA = false;
		}
		else if(color.a <= 0.0f)
		{
			changeA = true;
		}
		
		if(changeA == true)
		{
			color.a += Time.deltaTime;
		}
		else if (changeA == false)
		{
			color.a -= Time.deltaTime;
		}
		
		arrow.renderer.material.color = color;
	}
}
