using UnityEngine;
using System.Collections;

public class EvilOrGood : MonoBehaviour
{
	
		public Sprite sprite1; // good 
		public Sprite sprite2; // evil

	
		public Sprite sprite3; // good 
		public Sprite sprite4; // evil


		public bool lockSecondSprite = true;
		private bool evil = false;
		private SpriteRenderer spriteRenderer;
		private SpriteRenderer spriteRenderer2;
		private bool end;
		public int counter = 400;
	
		void Start ()
		{
				spriteRenderer = GameObject.Find ("EvilOrGoodScreen").GetComponent<SpriteRenderer> ();
				spriteRenderer.sprite = null; 
				spriteRenderer2 = GameObject.Find ("bad-bubble").GetComponent<SpriteRenderer> ();
				spriteRenderer2.sprite = null; 

		}
	
		void Update ()
		{
				if (end) {
						counter = counter - 1;
						if (counter <= 200) {
								foreach (GameObject g in GameObject.FindGameObjectsWithTag("ground")) {
										g.AddComponent<Rigidbody2D> ();
								}
						}
						if (counter <= 0) {
								Application.LoadLevel (Application.loadedLevelName);

						}
				}

		}
	
		void changeSprites ()
		{
				if (evil) { 
						spriteRenderer.sprite = sprite2;
						spriteRenderer2.sprite = sprite4;
				} else {
						spriteRenderer.sprite = sprite1; 
						spriteRenderer2.sprite = sprite3;
				}

		end = true;
		}
	
		void OnTriggerEnter2D (Collider2D col)
		{
				if (col.gameObject.tag == "Player") {
						changeSprites ();
				}
		}
	
}
