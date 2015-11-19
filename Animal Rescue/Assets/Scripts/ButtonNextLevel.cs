using UnityEngine;
using System.Collections;

public class ButtonNextLevel : MonoBehaviour 
{
	public Rect button = new Rect(15,15,200,110);
	public string buttonLabel = "Start game";
	public string levelToLoad;

	public void OnGUI(){
		if (GUI.Button(button, buttonLabel))
			Application.LoadLevel(levelToLoad);
	}
	/*public void NextLevelButton(int index)
	{
		Application.LoadLevel(index);
	}
	
	public void NextLevelButton(string levelName)
	{
		Debug.Log("Load " + levelName + "scene");
		Application.LoadLevel(levelName);
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Load start scene");
		Application.LoadLevel("Start");
	}
*/
}