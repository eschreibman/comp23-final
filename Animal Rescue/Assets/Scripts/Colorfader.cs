using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Colorfader : MonoBehaviour {

	public Color A ;
	public Color B ;
	public Color C ;

	public float speed;
	private Image col;

	void Start (){
		col = gameObject.GetComponent<Image> ();
	}
		
	void Update (){
		col.color = Color.Lerp (A, B, Mathf.PingPong (Time.time * speed, 1.0f));
	}

}
