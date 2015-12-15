using UnityEngine;
using System.Collections;

public class particleScript : MonoBehaviour {

	public bool pet;
	protected bool letPlay = true;
	
	public void Update()
	{
		pet = GameObject.Find("Player").GetComponent<collectAnimal>().carryingPet;
		//ParticleSystem exp = GetComponent<ParticleSystem>();
		//exp.Play();

		if(pet)
		{
			if(!gameObject.GetComponent<ParticleSystem>().isPlaying)
			{
				gameObject.GetComponent<ParticleSystem>().Play();
			}
		}else{
			if(gameObject.GetComponent<ParticleSystem>().isPlaying)
			{
				gameObject.GetComponent<ParticleSystem>().Stop();
			}
		}
	}
}

