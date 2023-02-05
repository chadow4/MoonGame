using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : MonoBehaviour
{
	int cashValue = 1;
	public AudioSource soundEffect;

	private void OnTriggerEnter2D(Collider2D other){
 		if(other.tag == "Player"){
			PlayerInventory inventory = other.GetComponent<PlayerInventory>();
			if(inventory != null){
				inventory.money = inventory.money + cashValue;
				print("Player inventory has " + inventory.money + " money in it.");
				soundEffect.Play();
				gameObject.SetActive(false);
			}
		}	
	}
}
