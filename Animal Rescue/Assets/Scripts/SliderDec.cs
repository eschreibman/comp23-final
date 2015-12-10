using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderDec : MonoBehaviour {
	//testing with speed = 0.01f
	public float speed;
	public float penalty;
	void Start (){


	}
	// Update is called once per frame
	void Update () {

		float n = (Time.timeSinceLevelLoad * speed);
		float dec = n * (Mathf.Log (1+n));

		Slider sMeter = GameObject.Find("SuspicionSlider").GetComponent<Slider>();

		//getting seen bool from player
		bool s = GameObject.Find("Player").GetComponent<PlayerMove>().seen;

		//if the player has been seen, increase slider more
		if(s){
			sMeter.value = dec + penalty;

		} else{
			sMeter.value = dec;
		}

		if(sMeter.value == 1){
			print ("game over");
		}
	}
}
