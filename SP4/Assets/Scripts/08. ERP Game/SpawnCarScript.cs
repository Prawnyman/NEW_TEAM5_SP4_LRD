using UnityEngine;
using System.Collections;

public class SpawnCarScript : MonoBehaviour {
	
	public Transform carPrefab;

	GameObject Timer;

	private enum Lanes{
		Top,
		Mid,
		Btm,
		None
	};
	
	Lanes currentLane;
	
	static Lanes GetRandomEnum<Lanes>()
	{
		System.Array A = System.Enum.GetValues(typeof(Lanes));
		Lanes lane = (Lanes)A.GetValue(UnityEngine.Random.Range(0, A.Length));
		return lane;
	}
	
	void SpawnCar(Lanes lane)
	{
		if(lane == Lanes.Top)
		{
			Instantiate(carPrefab, new Vector3(-11, 3.1f, 0), Quaternion.identity);
		}
		else if(lane == Lanes.Mid)
		{
			Instantiate(carPrefab, new Vector3(-11, 0.24f, 0), Quaternion.identity);
		}
		else if(lane == Lanes.Btm)
		{
			Instantiate(carPrefab, new Vector3(-11, -2.6f, 0), Quaternion.identity);
		}
		else if(lane == Lanes.None)
		{
		}
	}
	
	// Use this for initialization
	
	
	IEnumerator Start()
	{
		Timer = GameObject.FindGameObjectWithTag("timer");
		while(true)
		{
			yield return new WaitForSeconds(Random.Range(0.5f, 1));
			currentLane = GetRandomEnum<Lanes>();
			if (Timer.GetComponent<TimerScript>().timeLeft > 0)
				SpawnCar(currentLane);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
