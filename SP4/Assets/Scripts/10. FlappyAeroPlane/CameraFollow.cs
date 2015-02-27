using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	Transform Player;
	float offsetX;
	// Use this for initialization
	void Start () 
	{
		GameObject Player_Go = GameObject.FindGameObjectWithTag ("Player");
		if (Player_Go == null) 
		{
			Debug.LogError("cant find an Object with tag 'player'!");
			return;
		}
		Player = Player_Go.transform;
		offsetX = transform.position.x - Player.position.x;
	}
			
	// Update is called once per frame
	void Update () 
	{
		if (Player != null)
		{
			Vector3 pos = transform.position;
			pos.x = Player.position.x + offsetX;
			transform.position = pos;
		}
	}
}
