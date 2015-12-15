using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour {

	public int s = -1;
	public float moveSpeed = 4;
	public float rotationSpeed = 0.4f;
	public bool inStealth = false;
	public Material regMat;
	public Material stealthMat;
	public bool seen; 
	
	public Renderer rend;

	
	void Start() {
		rend = GetComponent<Renderer>();
		rend.enabled = true;

		if(GameObject.Find("infoObj")){
			info infoScript = GameObject.Find("infoObj").GetComponent<info>();
			if(infoScript.direction){
				s = -1;
				print ("s is negative");
			} else {
				s = 1;
				print ("s is pos");
			}
		}



	}

	void Update () {

		CharacterController controller = GetComponent<CharacterController>();

		//move forward and backwards
		Vector3 forward = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed, 0, 
		                              CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed);
		//makes player move in direction that it is facing, not absolute direction
		forward = transform.rotation * forward;

		inStealth = CrossPlatformInputManager.GetButton("Stealth");
		if(inStealth == true){
			//player cannot be seen but cannot pick up pet
			seen = false;
		} 

		//move the player forward
		controller.SimpleMove(forward);

		Joystick joystick = GameObject.Find("MobileJoystick").GetComponent<Joystick>();
		if (joystick != null) {
			if (joystick.usingJoystick && Input.touchCount > 1) {
				transform.Rotate(0, s * Input.GetTouch(1).deltaPosition.x * rotationSpeed, 0);
			} else if (!joystick.usingJoystick && Input.touchCount == 1) {
				transform.Rotate(0, s * Input.GetTouch(0).deltaPosition.x * rotationSpeed, 0);
			}
		}

	}
}
