using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour {
	public float speed = 4;
	bool inStealth = false;
	public Material regMat;
	public Material stealthMat;
	
	public Renderer rend;

	
	void Start() {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}

	void Update () {

		CharacterController controller = GetComponent<CharacterController>();

		//move forward and backwards
		Vector3 forward = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") * speed, 0, 
		                              CrossPlatformInputManager.GetAxis("Vertical") * speed);
		inStealth = CrossPlatformInputManager.GetButton("Stealth");
		if(inStealth == true){
			// Change renderer's material 	
			// assign it to the renderer
			rend.sharedMaterial = stealthMat;
		} else {
			rend.sharedMaterial = regMat;
		}
		controller.SimpleMove(forward);
	}
}
