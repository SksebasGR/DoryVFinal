using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreDown : MonoBehaviour
{
   private int contador = 0;
   public TextMeshProUGUI contadorTexto; // Referencia a un objeto Text en la interfaz de usuario
    
   void Update() {
       float movimientoVertical = Input.GetAxis("Vertical");
        
       if (movimientoVertical < 0) {
           contador++;
           contadorTexto.text = contador.ToString();
       }
   }
}
