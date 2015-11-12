using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderDec : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		float n = (Time.time * 0.1f);
		float dec = n * (Mathf.Log (1+n));

		Slider sMeter = GameObject.Find("SuspicionSlider").GetComponent<Slider>();
		sMeter.value = dec;

	}
}
