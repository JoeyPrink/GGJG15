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

    // sword sprite for 2d knight
    if (bazooka) {
      bazooka.renderer.enabled = true;
    }

    // sword for knight model
    GameObject sword = GameObject.FindWithTag("Sword");
    if (sword) {
      Debug.Log("Sword!");
      sword.GetComponent<MeshRenderer>().enabled = true;
    } else {
      Debug.Log("No sword!");
    }
	}


}
