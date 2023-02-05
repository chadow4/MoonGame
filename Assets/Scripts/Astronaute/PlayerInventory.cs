using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]

public class PlayerInventory : MonoBehaviour
{
   
   public int money = 0;
   public Text moneyScore;

   void Update(){
      if(money >= 5){
         Application.Quit();	
      }
      moneyScore.text = "Argent : " + money;
   }

}
