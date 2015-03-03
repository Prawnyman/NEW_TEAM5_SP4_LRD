using UnityEngine;
using System.Collections;

public class GameMusicScript : MonoBehaviour {
	public float MaxVolume;

	private static GameMusicScript instance = null;

	public static GameMusicScript Instance {
		get { return instance; }
	}

	void Awake() {
		audio.volume = MaxVolume;

		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
