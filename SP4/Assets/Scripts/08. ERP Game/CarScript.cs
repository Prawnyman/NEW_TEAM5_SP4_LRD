using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {
	
	private float difficulty = GlobalVariables.levelsPlayed * 0.5f;
	
	private Vector3 speed;
		
	GameObject Timer;

	// Use this for initialization
	void Start () {
		speed = new Vector3(10.0f + difficulty, 0, 0);
		Timer = GameObject.FindGameObjectWithTag("timer");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += speed * Time.deltaTime;
		
		if(transform.position.x > 11)
		{
			Destroy(this.gameObject);
			if (Timer.GetComponent<TimerScript>().timeLeft > 0)
				ERPLevel.lose = true;
		}

		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
			Destroy(this.gameObject);
	}
}
