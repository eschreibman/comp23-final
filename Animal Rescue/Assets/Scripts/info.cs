using UnityEngine;
using System.Collections;

public class info : MonoBehaviour {

	public bool direction;
	public int holdingScore;

	void Update () {
		Object.DontDestroyOnLoad(gameObject);

		if(GameObject.Find("Loader")){
			ButtonNextLevel buttonScript = GameObject.Find("Loader").GetComponent<ButtonNextLevel>();
			if(buttonScript.swipeDirection){
				direction = true;
			} else {
				direction = false;
			}
		}
		
		if(GameObject.Find("Player")){
			collectAnimal playerScript = GameObject.Find("Player").GetComponent<collectAnimal>();
			holdingScore = playerScript.score;
			print ("holding score");
		}
	}
		
}
