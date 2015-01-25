using UnityEngine;
using System.Collections;

public class RenderSprite : MonoBehaviour
{


		public Sprite sprite1;
		public Sprite sprite2;
		public string objectName;
		SpriteRenderer spriteRenderer;
		private bool triggered;

		// Use this for initialization
		void Start ()
		{
	
				spriteRenderer = GameObject.Find (objectName).GetComponent<SpriteRenderer> (); 
				spriteRenderer.sprite = sprite1;

		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerEnter2D (Collider2D col)
		{

				Debug.Log ("frist");
				if (col.gameObject.tag == "Player") {
						changeSprites (false);
				}
		}
	
		void OnTriggerExit2D (Collider2D col)
		{
				Debug.Log ("second");
				if (col.gameObject.tag == "Player") {
						changeSprites (true);
				}
		}

		void changeSprites (bool first)
		{

				if (!first) {
						
						spriteRenderer.sprite = sprite2;
						
				} else {
						spriteRenderer.sprite = sprite1; 
				}
		}

}
