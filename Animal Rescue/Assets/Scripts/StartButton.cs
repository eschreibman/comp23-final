using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour {
	private int levelOneIndex = 1;

	public void StartGame() {
		Application.LoadLevel(levelOneIndex);
	}
}
