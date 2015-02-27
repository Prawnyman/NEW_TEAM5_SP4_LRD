using UnityEngine;
using System.Collections;

public class Crack : MonoBehaviour {
	public GameObject Particle;
	public GameObject Particle2;
	public int ClickNumber; 
	public Sprite Default;
	public Sprite sprite1; 
	public Sprite sprite2;
	public Sprite sprite3; 
	public Sprite sprite4;
	public Sprite sprite5; 
	public Sprite sprite6;
	public Sprite sprite7; 
	public Sprite sprite8;
	public Sprite sprite9; 
	public Sprite sprite10;
	int clickcount;
	private SpriteRenderer spriteRenderer; 
	// Use this for initialization
	void Start () {
		clickcount = 0;
		spriteRenderer = GetComponent<SpriteRenderer>(); 
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = Default; // set the sprite to sprite1
	}
	
	// Update is called once per frame
	void Update () {
	
	}
void OnMouseDown()
	{
		ChangeSprite ();
	}
void ChangeSprite()
{
		clickcount++;
		audio.Play();
		if (clickcount >= ClickNumber) {

			if (spriteRenderer.sprite == Default) {
				spriteRenderer.sprite = sprite1;
			} else
			if (spriteRenderer.sprite == sprite1) {
				spriteRenderer.sprite = sprite2;
			} else
			if (spriteRenderer.sprite == sprite2) {
				spriteRenderer.sprite = sprite3;
			} else
			if (spriteRenderer.sprite == sprite3) {
				spriteRenderer.sprite = sprite4;
			} else
			if (spriteRenderer.sprite == sprite4) {
				spriteRenderer.sprite = sprite5;
			} else
			if (spriteRenderer.sprite == sprite5) {
				spriteRenderer.sprite = sprite6;
			} else
			if (spriteRenderer.sprite == sprite6) {
				spriteRenderer.sprite = sprite7;
			} else
			if (spriteRenderer.sprite == sprite7) {
				spriteRenderer.sprite = sprite8;
			} else
			if (spriteRenderer.sprite == sprite8) {
				spriteRenderer.sprite = sprite9;
			} else
			if (spriteRenderer.sprite == sprite9) {
				spriteRenderer.sprite = sprite10;
			} else
			if (spriteRenderer.sprite == sprite10) {
				Destroy (gameObject);
				GameObject obj2 = Instantiate(Particle2,gameObject.transform.position, Quaternion.identity) as GameObject;
			}
			clickcount=0;
		GameObject obj = Instantiate(Particle,gameObject.transform.position, Quaternion.identity) as GameObject;

		}
}
}