using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
   
   public int health = 3;
   public int maxHealth = 3;
   public Image healthBar;

   void Start() {
      healthBar.fillAmount = 1;
   
   }
   void Update(){
      if(health == 0){
         healthBar.fillAmount = 0;
         Time.timeScale = 0; // for debug
         Application.Quit();	
      }
      if(health == 1){
         healthBar.fillAmount = 0.33f;
      }
      if(health == 2){
         healthBar.fillAmount = 0.66f;
      }
    
   }

}
