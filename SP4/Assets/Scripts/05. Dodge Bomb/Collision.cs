using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public GameObject explosion;
	//GameObject player;
	int health = 3;
	void OnCollisionEnter2D (Collision2D col)
	{
		//player = GameObject.FindGameObjectWithTag("Player");
		//Debug.Log("collision name = " + col.gameObject.name);
		if ((col.gameObject.name == "BombTemp(Clone)")||(col.gameObject.name == "BombTemp"))
		{
			Destroy(col.gameObject);
			health=health -1;
			GameObject obj = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as GameObject;
			obj.tag = "";
			Destroy(gameObject);
			/*
			if (health <=0)
			{
				Destroy(gameObject);
				//Destroy(player);
			}
			*/
			// lose condition (get hit by bomb)
		}
	}

}
