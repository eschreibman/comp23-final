using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PetButton : MonoBehaviour {

	private bool pets = false;
	private bool carry = false;
	public Transform player;

	void Update () {
		//pets is true if player presses the pet button
		pets = CrossPlatformInputManager.GetButton("Pets");
		carry = player.GetComponent<collectAnimal>().carryingPet;

		//if the pet button is pressed and we are carrying a pet
		if(pets && carry){
			//dropping the pet off at the van
			//TODO add another conditional to only allow this to happen if we are standing near the "van"
			player.GetComponent<collectAnimal>().carryingPet = false;
		}
	
	}
}
