using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		//run only if there is a single finger on the screen
		if(Input.touchCount == 1){
			//basically move the object this script is attached to
			//towards the finger on the screen
			transform.Translate (Input.touches[0].deltaPosition.x*.04f,
			                     Input.touches[0].deltaPosition.y*.04f,
			                     0);
		}
		/*

		if(Input.touchCount == 1){
			//more instant kind of movement, not like an object being dragged
			Touch touch = Input.GetTouch(0);

			//get numbers by determing bounds of screen
			float x = -7.5f + 15 * touch.position.x / Screen.width;
			float y = -4.5f + 9 * touch.position.y / Screen.height;
			
			transform.position = new Vector3(x, y, 0);

		}
		*/
	}
}
