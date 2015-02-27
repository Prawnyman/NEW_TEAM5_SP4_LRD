using UnityEngine;
using System.Collections;

public class FireObject : MonoBehaviour {
	
	private int hp;
	
	// Use this for initialization
	void Start () {
		hp = 10;
	}			
	// Update is called once per frame
	
	void DestroySelf()
	{
		Destroy(this.gameObject);
	}
	
	void Update () {
		if(hp <= 0)
		{
			this.transform.localScale -= new Vector3(1.0F, 1.0F, 0);
			if(audio.isPlaying == false)
			{
				audio.Play();
			}
			Invoke("DestroySelf", audio.clip.length);
		}
	}
	
	void OnParticleCollision(GameObject other)
	{
		hp -= 1;
	}
	
	void OnDestroy()
	{
		audio.Stop();
		LevelInit.noFireObj -= 1;
	}
	
}