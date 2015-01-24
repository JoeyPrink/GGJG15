using UnityEngine;
using System.Collections;

public class ScrollingCredits : MonoBehaviour
{

		public float speed = 0.1f;
		public static ScrollingCredits Instance;
		private int counter = 0;

		// Use this for initialization
		void Start ()
		{
	
		}

		void Awake ()
		{
				Instance = this;
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
						Application.LoadLevel ("0 - Intro");

				}

		}
}
