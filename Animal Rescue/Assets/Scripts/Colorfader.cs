using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Colorfader : MonoBehaviour {

	public Color A ;
	public Color B ;
	public Color C ;
	//public Color D ;
	//public Color E ;

	public float speed;
	private Image col;
		//SpriteRenderer spriteRenderer;
		
	void Start (){
		col = gameObject.GetComponent<Image> ();
	}
		
	void Update (){
		/*float scaledT = t* (float)(N-1);
		Color prevC = Arr[(int)scaledT];
		Color nextC = Arr[(int)(scaledT+1f)];
		float newt = scaledT - (float)((int)scaledT); 
		col.color = Lerp5(A, B, C, D, E, t);*/
			col.color = Color.Lerp (A, B, Mathf.PingPong (Time.time * speed, 1.0f));
	}

	/*Color Lerp5(Color a, Color b, Color c, Color d, Color e, Color f, float t)
	{
		if (t < 0.2f) // 0.0 to 0.2 goes to a -> b
			return Color.Lerp(a, b, t / 0.5f);
		else if (t > 0.2f && t < 0.4f) // 0.2 to 0.4 goes to b -> c
			return Color.Lerp(b, c, (t - 0.5f) / 0.5f);
		else if (t > 0.4f && t < 0.6f) // 0.2 to 0.4 goes to b -> c
			return Color.Lerp(c, d, (t - 0.5f) / 0.5f);
		else if (t > 0.6f && t < 0.8f) // 0.2 to 0.4 goes to b -> c
			return Color.Lerp(d, e, (t - 0.5f) / 0.5f);
		else // 0.2 to 0.4 goes to b -> c
			return Color.Lerp(e, f, (t - 0.5f) / 0.5f);
	}*/
}
