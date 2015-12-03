using UnityEngine;
using System.Collections;

public class collectAnimal : MonoBehaviour {
	public Material matA;
	public Material matB;

	public Renderer rend;

	void Start() {
	/*	rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = matA;
*/
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("colliding");
		if(other.gameObject.CompareTag("Cat")){
			other.gameObject.SetActive(false);
		}
	/*	if(col.gameObject.name == "Player"){

			rend.sharedMaterial = matB;

		}
		else{
			rend.sharedMaterial = matA;
		}*/
	}
	void OnTriggerExit(Collider other){
		Debug.Log ("not colliding");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
