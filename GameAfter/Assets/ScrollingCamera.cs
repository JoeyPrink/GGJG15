using UnityEngine;
using System.Collections;

public class ScrollingCamera : MonoBehaviour
{

		public float speed = 25.0f; // x pixel per second

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 tmp = new Vector3 (transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
				transform.position = tmp;
		}
}
