using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenScore : MonoBehaviour
{
    
    private float _points; 
    public Image fillImage;
    public Image josttickImage;

    public float decreaseDuration = 60f;
    private float targetFillAmount;
    private float initialFillAmount;
    private float currentFillAmount;

    private void Start()
    {
        fillImage = GetComponent<Image>();
        josttickImage = GetComponent<Image>();
        initialFillAmount = fillImage.fillAmount;
        targetFillAmount = 0f;

        StartCoroutine(DecreaseFill());
    }
    

    private System.Collections.IEnumerator DecreaseFill()
    {
        float timeElapsed = 0f;

        while (timeElapsed < decreaseDuration)
        {
           
            
            timeElapsed += Time.deltaTime;
            float normalizedTime = timeElapsed / decreaseDuration;
            currentFillAmount = Mathf.Lerp(initialFillAmount, targetFillAmount, normalizedTime);
            fillImage.fillAmount = currentFillAmount;
            yield return null;

            Debug.Log(currentFillAmount + "belly");

            if (currentFillAmount > 0.5)
            {
                //josttickImage.color = new Color32(22, 187, 236, 146);
                fillImage.color = new Color32(22, 187, 236, 146);
                
            } else {
                fillImage.color = Color.red;
               // josttickImage.color = Color.red;
            }
        }

    }

    public void ChangeFillAmount(float pt)
    {
        _points += pt;  
    }
    public void ChangeTime(float pt)
    {
        decreaseDuration += pt;  
    }
    
}
