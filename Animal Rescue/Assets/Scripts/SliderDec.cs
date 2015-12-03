using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderDec : MonoBehaviour {

	public float speed = 0.05f;
	void Start (){


	}
	// Update is called once per frame
	void Update () {

		float n = (Time.timeSinceLevelLoad * speed);
		float dec = n * (Mathf.Log (1+n));

		Slider sMeter = GameObject.Find("SuspicionSlider").GetComponent<Slider>();
		sMeter.value = dec;

	}
}
