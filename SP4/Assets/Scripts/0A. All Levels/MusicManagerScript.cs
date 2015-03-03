using UnityEngine;
using System.Collections;

public class MusicManagerScript : MonoBehaviour {
	public AudioClip NewMusic;
	public bool StopOnStart;

	AudioSource gameMusic;

	void Awake () {
		gameMusic = GameObject.Find("Game Music").audio;	//Finds the game object called Game Music 

		if(NewMusic != gameMusic.clip && NewMusic != null){	//If audio is the same, don't change current audio
			gameMusic.clip = NewMusic;	//Replaces the old audio with the new one set in the inspector.
			gameMusic.Play();			//Plays the audio.
		}

		if(StopOnStart){
			gameMusic.Stop();

			if(NewMusic == null){
				gameMusic.clip = NewMusic;
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeMusic(AudioClip changeMusic){
		if(changeMusic != gameMusic.clip && changeMusic != null){	//If audio is the same, don't change current audio
			gameMusic.clip = changeMusic;	//Replaces the old audio with the new one set in the inspector.
			gameMusic.Play();			//Plays the audio.
		}
	}

	public void Play(){
		gameMusic.Play();
	}
	public void Pause(){
		gameMusic.Pause();
	}
	public void Stop(){
		gameMusic.Stop();
	}

	public void DisableMusic(){
		gameMusic.volume = 0.0f;
	}
	public void EnableMusic(){
		//gameMusic.volume = 1.0f;
		gameMusic.volume = gameMusic.GetComponent<GameMusicScript>().MaxVolume;
	}
}
