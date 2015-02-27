using UnityEngine;
using System.Collections;

public class WW2CharacterScript : MonoBehaviour {
	Vector2 dir = new Vector2(0, 1);
	bool reachedEndpoint = false;
	bool caughtByGuards = false;

	private Animator animator;

	GameObject Timer;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		Timer = GameObject.FindGameObjectWithTag("timer");
	}
	
	// Update is called once per frame
	void Update () {

		if (Timer.GetComponent<TimerScript>().timeLeft <= 0)
		{
			if (!reachedEndpoint)
				caughtByGuards = true;
		}

		if(!caughtByGuards && !reachedEndpoint){
#if UNITY_ANDROID
			if(Input.touches.Length > 0){
				Vector2 pos = this.transform.position;
				Vector2 pt = Camera.main.ScreenToWorldPoint(Input.touches[0].position);

				dir = (pt - pos).normalized;
				animator.SetBool("isMoving", true);
			}
			else{
				animator.SetBool("isMoving", false);
			}
#endif
#if UNITY_EDITOR
			if(Input.GetMouseButton(0)){
				Vector2 pos = this.transform.position;
				Vector2 pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);

				dir = (pt - pos).normalized;
				animator.SetBool("isMoving", true);
			}
			else{
				animator.SetBool("isMoving", false);
			}
#endif
			if(animator.GetBool("isMoving")){
				Vector2 maxPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
				Vector2 minPoint = Camera.main.ScreenToWorldPoint(Vector3.zero);
				float half_size = gameObject.renderer.bounds.size.x/2;

				if(dir.x > 0)
					this.transform.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(new Vector2(0, 1), dir));
				else if(dir.x < 0)
					this.transform.rotation = Quaternion.Euler(0, 0, Vector2.Angle(new Vector2(0, 1), dir));

				this.transform.Translate(dir * Time.deltaTime * 5, Space.World);

				if(this.transform.position.x > maxPoint.x - half_size || this.transform.position.x < minPoint.x + half_size){
					this.transform.Translate(new Vector2(-dir.x * Time.deltaTime * 5, 0), Space.World);
				}
				if(this.transform.position.y > maxPoint.y - half_size || this.transform.position.y < minPoint.y + half_size){
					this.transform.Translate(new Vector2(0, -dir.y * Time.deltaTime * 5), Space.World);
				}
			}
		}
	}//update

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "WW2 Endpoint"){
			reachedEndpoint = true;
			animator.SetBool("isMoving", false);

		}
		else if(col.gameObject.tag == "WW2 Guard" || col.gameObject.tag == "WW2 Guard_vision"){
			caughtByGuards = true;
			animator.SetBool("isMoving", false);
			animator.SetBool("isShot", true);
		}
	}


	public bool getReachedEndpoint(){
		return reachedEndpoint;
	}
	public bool getCaughtByGuards(){
		return caughtByGuards;
	}
}
