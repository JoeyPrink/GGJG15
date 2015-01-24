using UnityEngine;
using System.Collections;

public class pickup_sword : MonoBehaviour {

	public GameObject bazooka;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") 
			Destroy(this.gameObject);

		bazooka.renderer.enabled =true;
	}


}
