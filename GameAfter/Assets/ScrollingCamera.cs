﻿using UnityEngine;
using System.Collections;

public class ScrollingCamera : MonoBehaviour
{

		public float speed = 1.0f;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				Vector3 tmp = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
				transform.position = tmp;
		}
}