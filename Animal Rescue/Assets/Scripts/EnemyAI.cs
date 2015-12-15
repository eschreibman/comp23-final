using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	public float distanceToPlayer;
	public float detectDistance;
	public float warningDistance;

	public PlayerMove script;

	public float enemySpeed;
	public Transform playerPos;
	public Transform myTransform;
	public Transform modelTransform;
	public Renderer myRenderer;

	private Color standColor = Color.yellow;
	private Color warningColor = new Color (1f, 0.3f, 0f, 1f); //orange
	private Color detectColor = Color.red;
	private bool colliding = false;
	
	
	void Start(){
//		myRenderer = GetComponent<Renderer>();
//		if (myRenderer == null) {
//			myRenderer = GetComponentInChildren<Renderer>();
//		}
//		myTransform = GetComponent<Transform>();
		//initialized enemy to yellow
//		myRenderer.material.color = standColor;
	}
	
	void Update(){
		//get distance between self and player
		distanceToPlayer = Vector3.Distance(playerPos.position, transform.position);

		if (myRenderer) {
			if(distanceToPlayer < detectDistance){
				myRenderer.material.color = detectColor;
				//set seen on the player to be true
				script.seen = true;
			} else if(distanceToPlayer < warningDistance){
				myRenderer.material.color = warningColor;
			} else {
				script.seen = false;
				myRenderer.material.color = standColor;
			}
		}
		
		if(!colliding){
			enemyWalk();
		}
	}

	void enemyWalk(){
		transform.Translate(Vector3.forward * enemySpeed);
	}

	void OnCollisionEnter (Collision col)
	{
		colliding = true;
		//print ("collide");
		if(col.gameObject.tag == "Wall")
		{
			print ("call rotate");
			enemyRotate();
			colliding = false;
		} else{
			//we hit the player, stop walking for a moment
			StartCoroutine(waiting());
			colliding = false;
		}
	}

	void enemyRotate(){
		//randomly rotate
		/*int t = (int)(10 * Time.time);
		//print (t);
		if((t % 2) == 0){
			print ("mod 2");
			transform.Rotate(0,90,0);
		}else if((t % 3) == 0){
			print ("mod 3");
			transform.Rotate(90,0,0);} //buggy...
		else{
			print ("no mod");
			transform.Rotate(0,180,0);
		}*/
		enemySpeed = -enemySpeed;
		transform.Translate(Vector3.forward * enemySpeed);
		if (modelTransform != null) {
			modelTransform.Rotate(0, 180, 0);
		}
	}

	IEnumerator waiting(){
		transform.Translate(0, 0, 0);
	//	print (Time.time);
		yield return new WaitForSeconds (2);

	//	print (Time.time);

	}
}
