using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Follower : MonoBehaviour {
	public Transform target;
	public float ydistance = 5;
	public float zdistance = 10;
	void Update () {
		transform.position = new Vector3(target.position.x , target.position.y + ydistance, target.position.z - zdistance);
	}
}
