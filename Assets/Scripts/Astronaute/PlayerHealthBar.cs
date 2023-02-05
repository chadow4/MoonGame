using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
   
   public int health = 5;
   [SerializeField] Text healthScore;

   void Update(){
      if(health == 0){
         Application.Quit();	
      }
      healthScore.text = "Vie : " + health;
   }

}
