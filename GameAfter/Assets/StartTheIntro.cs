using UnityEngine;
using System.Collections;

public class StartTheIntro : MonoBehaviour
{


		public Sprite sprite;
		bool waited = false;
		public int waitingCounter = 0;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (waited) {
						waitingCounter = waitingCounter - 1;
						
						if (waitingCounter <= 0) {
								Application.LoadLevel ("1 - Credits");
						}
				}
		}

		void OnTriggerEnter2D (Collider2D col)
		{

				showFinalScreen ();
	
		}

		void showFinalScreen ()
		{
		
				SpriteRenderer spriteRenderer = GameObject.Find ("game_won_title").GetComponent<SpriteRenderer> (); 
				spriteRenderer.sprite = sprite; 

				SpriteRenderer spriteRenderer2 = GameObject.Find ("lifebar_full").GetComponent<SpriteRenderer> (); 
				spriteRenderer2.sprite = null; 
				waited = true;
		}
	


}
