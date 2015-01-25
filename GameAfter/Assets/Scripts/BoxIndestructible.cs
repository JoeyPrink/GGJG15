using UnityEngine;
using System.Collections;

public class BoxIndestructible : MonoBehaviour {
	
	private MeshRenderer ren;			// Reference to the sprite renderer.
	private bool destroyed = false;			// Whether or not the enemy is dead.

	public AudioClip[] moveClips;
	public AudioClip[] hitClips;
	public AudioClip[] pickupClips;

	bool holding = false;
	bool wasHolding = false;
	int direction = 0;
	private GameObject colObj;
	private BoxCollider2D box2DColloder;
	
	void Awake()
	{
		// Setting up the references.
		ren = transform.Find("Cube").GetComponent<MeshRenderer>();

		//playerTransform = GameObject.Find("Player").transform;
		
	}
	

	
	void Update()
	{
		if (holding && Input.GetButton("Fire2") && (colObj != null))
		{
			//Debug.Log (colObj.gameObject.tag);
			
			float x = (float) (colObj.transform.position.x + direction);
			float y = colObj.transform.position.y;
			
			Vector3 vect = new Vector3(x,y,this.transform.position.z);
			
			this.transform.position = vect;
			this.transform.rotation = colObj.transform.rotation;

			wasHolding = true;
			
			//this.transform.position = colObj.transform.position;
		}
		else 
		{
			holding =false;

			if (wasHolding)
			{
				int i = Random.Range(0, moveClips.Length);
				AudioSource.PlayClipAtPoint(moveClips[i], transform.position);
				wasHolding = false;
			}

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

				int i = Random.Range(0, pickupClips.Length);
				AudioSource.PlayClipAtPoint(pickupClips[i], transform.position);
				
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

}
