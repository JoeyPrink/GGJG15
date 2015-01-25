using UnityEngine;
using System.Collections;

public class scrollnifinal : MonoBehaviour {

		
		public float speed = 0.1f;

		private int counter = 0;
		
		// Use this for initialization
		void Start ()
		{
			
		}
		
		void Awake ()
		{

		}
		
		// Update is called once per frame
		void Update ()
		{
			
			
			Vector3 _tmp = this.transform.position;
			_tmp.y = _tmp.y - speed;
			
			if (_tmp.y > -310f) {
				this.transform.position = _tmp; // change Transform.position with it's setter		
			} else if (counter < 100) {
				counter = counter + 1;	
				
			}
			
		}
	}
