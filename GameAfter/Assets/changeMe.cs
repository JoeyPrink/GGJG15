using UnityEngine;
using System.Collections;

public class changeMe : MonoBehaviour {


	public int speed = 20;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;
	SpriteRenderer spriteRenderer;
	private int counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		counter = counter + 1;
		spriteRenderer = this.GetComponent<SpriteRenderer> ();
		if(counter%speed == 0) {
			if(spriteRenderer.sprite == sprite3) {
				spriteRenderer.sprite = sprite1;
			} else if(spriteRenderer.sprite == sprite2) {
				spriteRenderer.sprite = sprite3;
			}
			else if(spriteRenderer.sprite == sprite1) {
				spriteRenderer.sprite = sprite2;
			}
		}
	}
}
