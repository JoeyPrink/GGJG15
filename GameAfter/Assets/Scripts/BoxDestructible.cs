using UnityEngine;
using System.Collections;

public class BoxDestructible : MonoBehaviour {

	public int HP = 2;					// How many times the enemy can be hit before it dies.
	//public Texture2D destroyedBox;			// A sprite of the box when it's destroyed.
	//public Texture2D damagedBox;			// An optional sprite of the box when it's damaged
	public Material material_damaged;
	public Material material_destroyed;
	public AudioClip[] deathClips;		// An array of audioclips that can play when the enemy dies.
	public GameObject hundredPointsUI;	// A prefab of 100 that appears when the enemy dies.

	private MeshRenderer ren;			// Reference to the sprite renderer.
	private Transform frontCheck;		// Reference to the position of the gameobject used for checking if something is in front.
	private bool destroyed = false;			// Whether or not the enemy is dead.
	private Score score;				// Reference to the Score script.

	//private Texture2D destroyedBox;
	//private Texture2D damagedBox;


	bool holding = false;
	int direction = 0;
	private GameObject colObj;
	private BoxCollider2D box2DColloder;

	void Awake()
	{

		// Setting up the references.
		ren = transform.Find("Cube").GetComponent<MeshRenderer>();
		//frontCheck = transform.Find("frontCheck").transform;
		//score = GameObject.Find("Score").GetComponent<Score>();
		/*
		damagedBox = new Texture2D( (int)damagedBoxSprite.rect.width, (int)damagedBoxSprite.rect.height );

		//damagedBoxSprite.
		var pixels = damagedBoxSprite.texture.GetPixels( (int)damagedBoxSprite.textureRect.x,
		                                      (int)damagedBoxSprite.textureRect.y,
		                                      (int)damagedBoxSprite.textureRect.width,
		                                      (int)damagedBoxSprite.textureRect.height );
		
		damagedBox.SetPixels( pixels );
		damagedBox.Apply();
		*/




		//playerTransform = GameObject.Find("Player").transform;

	}

	public void Hit()
	{

		// Reduce the number of hit points by one.
		HP--;

		if (HP < 1)
						Desctruction ();
	}

	void Desctruction()
	{
		// Find all of the sprite renderers on this object and it's children.
		SpriteRenderer[] otherRenderers = GetComponentsInChildren<SpriteRenderer>();
		
		// Disable all of them sprite renderers.
		foreach(SpriteRenderer s in otherRenderers)
		{
			s.enabled = false;
		}
		
		// Re-enable the main sprite renderer and set it's sprite to the deadEnemy sprite.
		ren.enabled = true;
		//ren.material = material_destroyed; // TODO? new image
		
		// Increase the score by 100 points
		//score.score += 100;
		
		// Set dead to true.
		destroyed = true;
		
		// Allow the enemy to rotate and spin it by adding a torque.
		//rigidbody2D.fixedAngle = false;
		//rigidbody2D.AddTorque(Random.Range(deathSpinMin,deathSpinMax));
		
		// Find all of the colliders on the gameobject and set them all to be triggers.
		Collider2D[] cols = GetComponents<Collider2D>();
		foreach(Collider2D c in cols)
		{
			c.isTrigger = true;
		}
		
		// Play a random audioclip from the deathClips array.
		//int i = Random.Range(0, deathClips.Length);
		//AudioSource.PlayClipAtPoint(deathClips[i], transform.position);
		
		// Create a vector that is just above the enemy.
		Vector3 scorePos;
		scorePos = transform.position;
		scorePos.y += 1.5f;
		
		// Instantiate the 100 points prefab at this point.
		Instantiate(hundredPointsUI, scorePos, Quaternion.identity);

		// Destroy the box.
		Destroy (gameObject);
	}

	void Update()
	{
		if (holding && Input.GetButton("Fire2") && (colObj != null))
		{
			//Debug.Log (colObj.gameObject.tag);

			float x = (float) (colObj.transform.position.x + direction);
			float y = colObj.transform.position.y;
			
			Vector3 vect = new Vector3(x,y,colObj.transform.position.z);

			this.transform.position = vect;
			this.transform.rotation = colObj.transform.rotation;
		 
			//this.transform.position = colObj.transform.position;
		}
		else 
		{
			//Debug.Log ("no longer holding");
			holding =false;
			//this.collider2D.enabled = true;
			//this.rigidbody2D.isKinematic = false;
			//Destroy(colObj);
		}

	}

	void OnCollisionStay2D (Collision2D col)
	{

		Collider2D collider = col.collider;

		// If the colliding gameobject is an Enemy...
		if (col.gameObject.tag == "Player") {

						Vector3 contactPoint = col.contacts [0].point;
						Vector3 center = collider.bounds.center;

						bool right = contactPoint.x < center.x;
						bool top = contactPoint.y < center.y;
						bool bottom = contactPoint.y > center.y;
						bool left = contactPoint.x > center.x;

						//Debug.Log("Cols:" + right.ToString() + top.ToString() + left.ToString());
						if (Input.GetButtonDown ("Fire2") && (right || left)) {
								Debug.Log ("Pick Up Box");

								//Vector3 temp = transform.position; // copy to an auxiliary variable...
								//temp.y = 7.0f; // modify the component you want in the variable...
								//transform.position = temp; // and save the modified value 

								holding = true;
								colObj = col.gameObject;

								//this.collider2D.enabled = false;
								//rigidbody.isKinematic = true;
								//this.rigidbody2D.isKinematic = true;
								//this.rigidbody2D.collisionDetectionMode =

								if (right) direction = -2;
								else direction = 2;

								//this.transform.position = holdSlot.transform.position;

						}
				} 
	}



	void FixedUpdate ()
	{
		// Create an array of all the colliders in front of the enemy.
		//Collider2D[] frontHits = Physics2D.OverlapPointAll(frontCheck.position, 1);


		
		// Check each of the colliders.
		/*
		foreach(Collider2D c in frontHits)
		{
			// If any of the colliders is an Obstacle...
			if(c.tag == "Obstacle")
			{
				// ... Flip the enemy and stop checking the other colliders.
				Flip ();
				break;
			}
		}
		*/
		
		// Set the enemy's velocity to moveSpeed in the x direction.
		//rigidbody2D.velocity = new Vector2(transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);	

		Texture2D tex = Resources.Load("part_flame.png") as Texture2D;
		
		// If the enemy has one hit point left and has a damagedEnemy sprite...
		if(HP == 1)
			// ... set the sprite renderer's sprite to be the damagedEnemy sprite.
			//ren.sprite = damagedBox;
			//this.renderer.material.mainTexture = tex;
			ren.material = material_damaged; // .material.SetTexture("Box_damaged", damagedBox);
		
		// If the enemy has zero or fewer hit points and isn't dead yet...
		if(HP <= 0 && !destroyed)
			// ... call the death function.
			Desctruction ();
	}
}
