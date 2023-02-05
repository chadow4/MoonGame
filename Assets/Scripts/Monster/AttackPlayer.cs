using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
	public AudioSource soundEffect;
	private float shakeDuration = 0.5f;
	private float shakeAmount = 0.1f;
	private Vector3 originalPosition;

	private void OnTriggerEnter2D(Collider2D other){
 		if(other.tag == "Player"){
			PlayerHealthBar healthBar = other.GetComponent<PlayerHealthBar>();
			if(healthBar != null){
				healthBar.health = healthBar.health -1;
				print(other.tag + " took damage " + " currentLife is " + healthBar.health);
				soundEffect.Play();
				StartCoroutine(Shake(other.gameObject));
			}
		}	
	}

	private IEnumerator Shake(GameObject obj) {
   		float elapsed = 0.0f;
   		originalPosition = obj.transform.position;

   		while (elapsed < shakeDuration) {
      		float x = Random.Range(-0.1f, 0.1f) * shakeAmount;
      		float y = Random.Range(-0.1f, 0.1f) * shakeAmount;

      	obj.transform.position = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);

     	elapsed += Time.deltaTime;

      	yield return null;
   		}

   		obj.transform.position = originalPosition;
	}
}
