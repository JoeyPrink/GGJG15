using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlHandler : MonoBehaviour
{


		private bool showControls = true;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				if (Input.GetKeyDown (KeyCode.C)) {
						print ("space key was pressed");
						
						if (!showControls) {
								showControls = true;

								GameObject.Find ("Image-controls1").GetComponent<Image> ().enabled = true;
								GameObject.Find ("Image-controls2").GetComponent<Image> ().enabled = true;

						} else {
								showControls = false;
								GameObject.Find ("Image-controls1").GetComponent<Image> ().enabled = false;
								GameObject.Find ("Image-controls2").GetComponent<Image> ().enabled = false;

								/*int tmp = GameObject.Find ("Image-controls1").GetComponent<Image> ().color.a;
								GameObject.Find ("Image-controls1").GetComponent<Image> ().color.a = 0;*/
						}
				}

		}
}
