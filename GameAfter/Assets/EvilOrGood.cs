using UnityEngine;
using System.Collections;

public class EvilOrGood : MonoBehaviour
{
	
	public Sprite sprite1; // good 
	public Sprite sprite2; // evil

	public bool lockSecondSprite = true;
	private bool evil = false;
	private SpriteRenderer spriteRenderer;
	
	void Start ()
	{
		spriteRenderer = GameObject.Find ("EvilOrGoodScreen").GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = null; 
	}
	
	void Update ()
	{
	}
	
	void changeSprites ()
	{
		if (evil) { 
			spriteRenderer.sprite = sprite2;
		} else {
			spriteRenderer.sprite = sprite1; 
		}
	}

	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			changeSprites();
		}
	}
	
}
