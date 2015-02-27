using UnityEngine;
using System.Collections;

public class PlaneScript : MonoBehaviour {
	private float initialRotation;
	private float finalRotation;
	private bool touchedGround;
	private float newInitialRotation;

#if UNITY_EDITOR
	private static float keyRotation = 0.0f;
#endif

	// Use this for initialization
	void Start () {
		initialRotation = 0.0f;
		while(initialRotation > -5.0f && initialRotation < 5.0f){
			initialRotation = Random.Range(-35, 35);
		}

		finalRotation = initialRotation;
		newInitialRotation = initialRotation;
		touchedGround = false;

		this.transform.rotation = Quaternion.Euler(0, 0, finalRotation);
	}
	
	// Update is called once per frame
	void Update () {
		if(!touchedGround){
			updateInitialRotation();

#if UNITY_ANDROID
			//Get tilt input
			finalRotation = initialRotation + Input.acceleration.x * -70;
#endif
#if UNITY_EDITOR
			if(Input.GetKey(KeyCode.LeftArrow)){
				keyRotation += 2.0f;
			}
			if(Input.GetKey(KeyCode.RightArrow)){
				keyRotation -= 2.0f;
			}

			finalRotation = initialRotation + keyRotation;
#endif

			//Limit amount of rotation plane can have
			if (finalRotation > 35.0f) {
				finalRotation = 35.0f;
			}
			else if(finalRotation < -35.0f){
				finalRotation = -35.0f;
			}
			
			//Update plane rotation
			this.transform.rotation = Quaternion.Euler(0, 0, finalRotation);

			//Plane constantly moves downwards
			this.transform.Translate((Vector3.down + Vector3.right * 2) * Time.deltaTime, Space.World);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Ground"){
			touchedGround = true;
		}
	}

	void updateInitialRotation(){
		if(this.transform.position.y > -1.5f){
			if(Mathf.Abs(initialRotation - newInitialRotation) <= 0.75f){
				initialRotation = newInitialRotation;
				newInitialRotation = Random.Range(-35, 35);
			}
			
			if(newInitialRotation - initialRotation > 0){
				initialRotation += 20.0f * Time.deltaTime;
			}
			else if(newInitialRotation - initialRotation < 0){
				initialRotation -= 20.0f * Time.deltaTime;
			}
		}
	}

	public bool getTouchedGround(){
		return touchedGround;
	}
	public float getRotation(){
		return finalRotation;
	}

	public void landPlane(){
		this.transform.rotation = Quaternion.Euler(0, 0, 0);
		this.transform.position.Set(this.transform.position.x, -3.6f, 0);
	}
}
