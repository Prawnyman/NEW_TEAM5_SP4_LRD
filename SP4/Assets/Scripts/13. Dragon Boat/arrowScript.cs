using UnityEngine;
using System.Collections;

public class arrowScript : MonoBehaviour {
	
	public GameObject arrow;
	Color color;
	// Use this for initialization
	void Start () {
		color = arrow.renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (color.a >= 1.0f){
			color.a -= Time.deltaTime;
			if(color.a <= 0.0f)
			{
				color.a += Time.deltaTime;
			}
		}
		
		arrow.renderer.material.color = color;
	}
}
