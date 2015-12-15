using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Colorfader : MonoBehaviour {

	public Color A ; //826DDFFF
	public Color B ; //6F6E76FF
	public Color C ; //313130FF

	public float speed; //1
	private Image col;

	void Start (){
		col = gameObject.GetComponent<Image> ();
	}
		
	void Update (){
		col.color = Color.Lerp (A, B, Mathf.PingPong (Time.time * speed, 1.0f));
	}

}
