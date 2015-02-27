using UnityEngine;
using System.Collections;
public class PC_Control : MonoBehaviour {
	Vector3 dir = Vector3.zero;
	float moveSpeed = 0.5f;

	GameObject Timer;
	
	void Start()
	{
		Timer = GameObject.FindGameObjectWithTag("timer");
	}

	// Update is called once per frame
	void Update () {
		if (Timer.GetComponent<TimerScript>().timeLeft > 0)
		{
			#if UNITY_ANDROID
				dir.x = Input.acceleration.x * moveSpeed;
					transform.Translate (dir.x, 0, 0);
			#endif
				if (Input.GetKey (KeyCode.RightArrow)) {
					dir.x = 0.5f* moveSpeed;
					transform.Translate (dir.x, 0, 0);
				}
				
				if (Input.GetKey (KeyCode.LeftArrow)) {
					dir.x = -0.5f* moveSpeed;
					transform.Translate (dir.x, 0, 0);
				}
		}
	}//update
}
