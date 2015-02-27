using UnityEngine;
using System.Collections;

public class GantryScript : MonoBehaviour {
	
	private Vector2 fp;
	private Vector2 lp;
	private	float yChange = 0.0f;
	
	public GameObject particlesPrefab;
	
	private enum Lanes{
		Top,
		Mid,
		Btm,
	};
	
	Lanes currentLane;
	
	Vector3 SetPosition()
	{
		Vector3 position = new Vector3(0, 0, 0);
	
		if(currentLane == Lanes.Top)
		{
			position = new Vector3(9, 3, 0);
		}
		else if(currentLane == Lanes.Mid)
		{
			position = new Vector3(9, 0.2f, 0);
		}
		else if(currentLane == Lanes.Btm)
		{
			position = new Vector3(9, -2.6f, 0);
		}
		
		return position;
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Car")
		{
			Destroy(collider.gameObject);
			Instantiate(particlesPrefab, collider.transform.position, Quaternion.identity);
		}
	}
	
	void Win(){}
	void Lose(){}
	
	// Use this for initialization
	void Start () {
		currentLane = Lanes.Mid;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = SetPosition();
		
		#if UNITY_EDITOR
		if(Input.GetKeyDown("up") )
		{
			if(currentLane == Lanes.Mid)
			{
				currentLane = Lanes.Top;
			}
			if(currentLane == Lanes.Btm)
			{
				currentLane = Lanes.Mid;
			}
		}
		if(Input.GetKeyDown("down"))
		{
			if(currentLane == Lanes.Mid)
			{
				currentLane = Lanes.Btm;
			}
			if(currentLane == Lanes.Top)
			{
				currentLane = Lanes.Mid;
			}
		}
		#endif	
		
		#if UNITY_ANDROID
		if(Input.touches.Length > 0)
		{
			if(Input.touchCount == 1)
			{
				Touch touch = Input.GetTouch(0);
				
				if(touch.phase == TouchPhase.Began)
				{
					fp = touch.position;
					lp = touch.position;
				}
				if(touch.phase == TouchPhase.Moved)
				{
					lp = touch.position;
					yChange = lp.y - fp.y;
					fp = touch.position;
				}
				
				if(touch.phase == TouchPhase.Ended)
				{
					if(yChange > 0)
					{
						if(currentLane == Lanes.Mid)
						{
							currentLane = Lanes.Top;
						}
						else if(currentLane == Lanes.Btm)
						{
							currentLane = Lanes.Mid;
						}
					}
					else if(yChange < 0)
					{
						if(currentLane == Lanes.Mid)
						{
							currentLane = Lanes.Btm;
						}
						else if(currentLane == Lanes.Top)
						{
							currentLane = Lanes.Mid;
						}
					}
				}
			}
		}
		#endif
	}
}
