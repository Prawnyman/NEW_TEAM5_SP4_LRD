using UnityEngine;
using System.Collections;

public class BombBeheavior : MonoBehaviour {
	public GameObject Boom;
	GameObject Timer;
	private Vector3 speed;
	private float difficulty = GlobalVariables.levelsPlayed * 0.5f;

	void Start()
	{
		speed = new Vector3(0, -10.0f - difficulty, 0);
		Timer = GameObject.FindGameObjectWithTag("timer");
	}

	void Update()
	{
		transform.position += speed * Time.deltaTime;

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
