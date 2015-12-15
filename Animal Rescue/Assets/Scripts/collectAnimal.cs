using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collectAnimal : MonoBehaviour {
	public int score;
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
	
	void Update () {
		if(carryingPet){
			petText.color = withPetColor;
		}
		else {
			petText.color = defaultColor;
		}
	}

	void OnTriggerEnter(Collider other){
		//player will "pick up" pet if they collide and they are not already carrying a pet
		if(other.gameObject.CompareTag("Cat") && !carryingPet){
			bool st = GameObject.Find("Player").GetComponent<PlayerMove>().inStealth;
			if (!st){
				carryingPet = true;
				Destroy(other.gameObject);
				score++;
			}
		}
	}
	void OnTriggerExit(Collider other){
		Debug.Log ("not colliding");
	}



}
