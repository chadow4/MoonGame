using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
	public AudioSource soundEffect;

	private void OnTriggerEnter2D(Collider2D other){
 		if(other.tag == "Player"){
			PlayerHealthBar healthBar = other.GetComponent<PlayerHealthBar>();
			if(healthBar != null){
				healthBar.health = healthBar.health -1;
				print(other.tag + " took damage " + " currentLife is " + healthBar.health);
				soundEffect.Play();
			}
		}	
	}
}
