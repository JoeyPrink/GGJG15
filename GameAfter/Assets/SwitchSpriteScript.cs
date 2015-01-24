using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour
{

		public Sprite sprite1;
		public Sprite sprite2;
		public Sprite sprite_remote1;
		public Sprite sprite_remote2;
		public bool lockSecondSprite = true;
		public string gameObjectName;
		private bool triggered = false;
		private SpriteRenderer spriteRenderer;
		private SpriteRenderer remoteSpriteRenderer;
	
		void Start ()
		{
				spriteRenderer = GetComponent<SpriteRenderer> ();
				remoteSpriteRenderer = GameObject.Find (gameObjectName).GetComponent<SpriteRenderer> (); 

				spriteRenderer.sprite = sprite1; 
				remoteSpriteRenderer.sprite = sprite_remote1;
				if (lockSecondSprite)
						lockSecondObject ();
		}
	
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.E) && triggered) {
						ChangeSprites (); 
				}
		}
	
		void ChangeSprites ()
		{
				if (spriteRenderer.sprite == sprite1) { 
						spriteRenderer.sprite = sprite2;
						if (lockSecondSprite)
								unlockSecondObject ();
				} else {
						spriteRenderer.sprite = sprite1; 
						if (lockSecondSprite)
								lockSecondObject ();
				}

				if (remoteSpriteRenderer.sprite == sprite_remote1) { 
						remoteSpriteRenderer.sprite = sprite_remote2;
				} else {
						remoteSpriteRenderer.sprite = sprite_remote1;
				}
		}

		void lockSecondObject ()
		{
				GameObject.Find (gameObjectName).GetComponent<BoxCollider2D> ().isTrigger = false;
		}

		void unlockSecondObject ()
		{
				GameObject.Find (gameObjectName).GetComponent<BoxCollider2D> ().isTrigger = true;
		}

		void OnTriggerEnter2D (Collider2D col)
		{
				if (col.gameObject.tag == "Player") {
						triggered = true;
				}
		}

		void OnTriggerExit2D (Collider2D col)
		{
				if (col.gameObject.tag == "Player") {
						triggered = false;
				}
		}


}
