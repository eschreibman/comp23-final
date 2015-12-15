using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayScore : MonoBehaviour {

	private int finalScore;
	private Text scoreText;
	Rect startButton = new Rect(1225,800,300,210);
	string startLabel = "Yes!";
	int fontSize = 50;
	public string levelToLoad;
	

	void Start () {
		scoreText = gameObject.GetComponent<Text>();

		if(GameObject.Find("infoObj")){
			info infoScript = GameObject.Find("infoObj").GetComponent<info>();
			finalScore = infoScript.holdingScore;
		}

	}

	void Update () {
		scoreText.text = "You rescued: " + finalScore + " pets\n" +
			"\nBut there are more that need your help! Play again?";
	
	}

	public void OnGUI(){
		GUI.skin.button.fontSize = fontSize;
		if (GUI.Button(startButton, startLabel)){
				Application.LoadLevel(levelToLoad);
		} 
	}


}
