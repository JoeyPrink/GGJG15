using UnityEngine;
using System.Collections;

public class mushroom : MonoBehaviour {

	public float jumpforce = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter2D(Collider2D other) {

		Vector2 force = new Vector2 (0, jumpforce);

		if (other.tag == "Player") {
			Debug.Log ("player on me, go away");

			//other.rigidbody2D.AddForce(force, ForceMode2D.Impulse);
			other.GetComponent<PlayerControl>().forcedJump(jumpforce);
		
		}

	}
}
