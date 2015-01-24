using UnityEngine;
using System.Collections;

public class choppableTree : MonoBehaviour {

	// Use this for initialization

	public int HP = 2;
	public float xCorrection = -2f;
	public float yCorrection = -2f;
	public float rotation = 90f;


	void Start () {
	
	}

	public void Hit()
	{
		
		// Reduce the number of hit points by one.
		HP--;
	}

	// Update is called once per frame
	void Update () {
	
		if (HP==0){
			HP--;
			transform.Rotate(0,0,rotation);
			transform.position = new Vector3 (transform.position.x + xCorrection, transform.position.y + yCorrection);
		}
	}
}
