using UnityEngine;
using System.Collections;

public class DestroyerOfWorlds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown(KeyCode.R)) {
      destroyTheWorld();
    }
	}

  public void destroyTheWorld() {
    foreach (GameObject g in GameObject.FindGameObjectsWithTag("ground")) {
      g.AddComponent<Rigidbody2D>();
    }
  }
}
