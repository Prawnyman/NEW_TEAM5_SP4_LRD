using UnityEngine;
using System.Collections;

public class ExplosionAnimationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (destroyExplosion());
	}

	private IEnumerator destroyExplosion(){
		yield return new WaitForSeconds (0.8f);
		DestroyObject(gameObject);
	}
}
