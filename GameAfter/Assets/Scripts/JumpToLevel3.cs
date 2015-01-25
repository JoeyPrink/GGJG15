using UnityEngine;
using System.Collections;

public class JumpToLevel3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		Debug.Log ("yeah");
		Application.LoadLevel ("4 - Level 3");
		
	}
}
