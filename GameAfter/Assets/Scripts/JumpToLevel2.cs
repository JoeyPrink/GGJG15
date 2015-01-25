using UnityEngine;
using System.Collections;

public class JumpToLevel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		
		Application.LoadLevel ("3 - Level 2");
		
	}
}
