using UnityEngine;
using System.Collections;

public class BombBeheavior : MonoBehaviour {
	public GameObject Boom;
	GameObject Timer;

	void Start()
	{
		Timer = GameObject.FindGameObjectWithTag("timer");
	}

	void Update()
	{
		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
			Destroy(gameObject);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		//Debug.Log("collision name = " + col.gameObject.name);
		if (col.gameObject.name == "Wall")
		{
			Destroy(gameObject);
			GameObject obj = Instantiate(Boom, gameObject.transform.position, Quaternion.identity) as GameObject;
		}
	}
	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}
}
