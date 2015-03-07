using UnityEngine;
using System.Collections;

public class EvilOrGood : MonoBehaviour
{
	
		public Sprite sprite1; // good 
		public Sprite sprite2; // evil
	
		public Sprite sprite3; // good 
		public Sprite sprite4; // evil

		public Sprite sprite5; // good 
		public Sprite sprite6; // evil

		public Sprite sprite7; // good 
		public Sprite sprite8; // evil

		public Sprite sprite9; // good 
		public Sprite sprite10; // evil

		public Sprite sprite11; // good 
		public Sprite sprite12; // evil


		public bool lockSecondSprite = true;
		private bool evil = false;
		private SpriteRenderer spriteRenderer;
		private SpriteRenderer spriteRenderer2;
		private SpriteRenderer spriteRenderer3;
		private SpriteRenderer spriteRenderer4;
		private SpriteRenderer spriteRenderer5;
		private SpriteRenderer spriteRenderer6;
		private bool end;
		public float counter = 10; // seconds
    private bool worldDestroyed = false;

		void Start ()
		{
				spriteRenderer = GameObject.Find ("EvilOrGoodScreen").GetComponent<SpriteRenderer> ();
				spriteRenderer.sprite = null; 
				spriteRenderer2 = GameObject.Find ("bad-bubble").GetComponent<SpriteRenderer> ();
				spriteRenderer2.sprite = null; 
				spriteRenderer3 = GameObject.Find ("annoying_person02").GetComponent<SpriteRenderer> ();
				spriteRenderer3.sprite = null; 
				spriteRenderer4 = GameObject.Find ("dragonkid01_dead").GetComponent<SpriteRenderer> ();
				spriteRenderer4.sprite = null; 
				spriteRenderer5 = GameObject.Find ("dragonkid02_dead").GetComponent<SpriteRenderer> ();
				spriteRenderer5.sprite = null; 
				spriteRenderer6 = GameObject.Find ("dragon_defeated").GetComponent<SpriteRenderer> ();
				spriteRenderer6.sprite = null; 


		}
	
		void Update ()
		{
			if (end) {
				counter = counter - Time.deltaTime;
            
                if (counter < 3 && !worldDestroyed) {
				    foreach (GameObject g in GameObject.FindGameObjectsWithTag("ground")) {
					    g.AddComponent<Rigidbody2D> ();
				    }
                    worldDestroyed = true;
			    }
			
                if (counter <= 0) {
					Application.LoadLevel ("6 - Credits");
                }
		    }
		}
	
		void changeSprites ()
		{
				if (evil) { 
						spriteRenderer.sprite = sprite2;
						spriteRenderer2.sprite = sprite4;
						spriteRenderer3.sprite = sprite6;
						spriteRenderer4.sprite = sprite8;
						spriteRenderer5.sprite = sprite10;
						spriteRenderer6.sprite = sprite12;
				} else {
						spriteRenderer.sprite = sprite1; 
						spriteRenderer2.sprite = sprite3;
						spriteRenderer3.sprite = sprite5;
						spriteRenderer4.sprite = sprite7;
						spriteRenderer5.sprite = sprite9;
						spriteRenderer6.sprite = sprite11;
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
