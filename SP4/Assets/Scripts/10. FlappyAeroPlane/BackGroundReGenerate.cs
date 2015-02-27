using UnityEngine;
using System.Collections;

public class BackGroundReGenerate : MonoBehaviour 
{
	int NumOfS = 3;
	void OnTriggerEnter2D(Collider2D collider)
	{
		//Debug.Log ("Triggered: " + collider.name);
		float WidthOfBGObject =((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += WidthOfBGObject * NumOfS - WidthOfBGObject/10.0f;
		collider.transform.position = pos;
	}
}
