using UnityEngine;
using System.Collections;
public class BombScript : MonoBehaviour
{
	public GameObject spawnType;
	public int spawnCount;
	public float spawnDelay;
	public float DiffupDelay;
	private float DiffupPrev;
	private float spawnPrev;

	GameObject Timer;

	// Use this for initialization
	void Start ()
	{
		spawnPrev=DiffupPrev = Time.time;
		Timer = GameObject.FindGameObjectWithTag("timer");
	}
	
	// Update is called once per frame
	void Update ()
	{

		float now = Time.time;
		float diff = (now - spawnPrev) * 1000;
		float diff2 = (now - DiffupPrev) * 1000;

		if ((diff2 > DiffupDelay)&&(spawnDelay>200)) {
			spawnDelay = spawnDelay - 20;
			if (spawnDelay < 100)
				spawnDelay = 100;
			//Debug.Log(spawnDelay);
			DiffupPrev = now;
		}

		if (diff < spawnDelay) {
			return;
		}
		spawnPrev = now;

		for (int i=0; i<spawnCount; i++) {
			float x = Random.Range (-12, 12);
			float y = Random.Range (7, 9);

			Instantiate (spawnType, new Vector3 (x, y, 0), Quaternion.identity);
		}

		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
			Destroy(gameObject);
	} 
}
	
