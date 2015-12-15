using UnityEngine;
using System.Collections;

public class ButtonNextLevel : MonoBehaviour 
{
	public Rect startButton = new Rect(20,20,200,110); //1225, 950
	public Rect dirButton = new Rect(1450,960,130,90);
	public Rect invButton = new Rect(1610,960,130,90);
	string startLabel = "Start game";
	string dirLabel = "Natural swipe";
	string invLabel = "Reverse swipe";
	int fontSize = 20;
	public string levelToLoad; 
	public bool swipeDirection = false;

	public void OnGUI(){
		GUI.skin.button.fontSize = fontSize;
		if (GUI.Button(startButton, startLabel)){
			Application.LoadLevel(levelToLoad);
		} else if (GUI.Button(dirButton, dirLabel)){
			swipeDirection = true;
		} else if (GUI.Button(invButton, invLabel)){
			swipeDirection = false;
		}
	}
}