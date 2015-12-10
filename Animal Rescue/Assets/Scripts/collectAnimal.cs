using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collectAnimal : MonoBehaviour {
	public bool carryingPet;
	private Text petText;
	private Color defaultColor;
	private Color withPetColor;
	private GameObject stick;
	private GameObject inventory;

	void Start() {
		carryingPet = false;
		defaultColor = new Color(1,0,0,1);
		withPetColor = new Color(0,1,0,1);
		stick = GameObject.Find("MobileSingleStickControl");
		inventory = stick.transform.Find("Pet Inventory").gameObject;
		petText = inventory.GetComponentInChildren<Text>();
	}

	void OnTriggerEnter(Collider other){
		//player will "pick up" pet if they collide and they are not already carrying a pet
		if(other.gameObject.CompareTag("Cat") && !carryingPet){
			carryingPet = true;
			//other.gameObject.SetActive(false);
			Destroy(other.gameObject);
		}
	}
	void OnTriggerExit(Collider other){
		Debug.Log ("not colliding");
	}
	// Update is called once per frame
	void Update () {
		if(carryingPet){
			petText.color = withPetColor;
		}
		else {
			petText.color = defaultColor;
		}
	}
}
