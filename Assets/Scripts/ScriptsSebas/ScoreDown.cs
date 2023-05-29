using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class ScoreDown : MonoBehaviour
{

   private int score = 0;
   public TextMeshProUGUI scoreText; // Referencia a un objeto Text en la interfaz de usuario

    
   void Update() {
       float movementVertical = Input.GetAxis("Vertical");
        
       if (movementVertical < 0) {
            score++;
            scoreText.text = score.ToString() + " mts";
       }

   }
}
