using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenScore : MonoBehaviour
{
    
    private float _points; 
    public Image fillImage;
    
    public float decreaseDuration = 60f;
    private float targetFillAmount;
    private float initialFillAmount;
    private float currentFillAmount;

    private void Start()
    {
        fillImage = GetComponent<Image>();
        initialFillAmount = fillImage.fillAmount;
        targetFillAmount = 0f;
        
        StartCoroutine(DecreaseFill());
    }
    

    private System.Collections.IEnumerator DecreaseFill()
    {
        float timeElapsed = 0f;

        while (timeElapsed < decreaseDuration)
        {
            Debug.Log(timeElapsed);
            Debug.Log(decreaseDuration);
            
            timeElapsed += Time.deltaTime;
            float normalizedTime = timeElapsed / decreaseDuration;
            currentFillAmount = Mathf.Lerp(initialFillAmount, targetFillAmount, normalizedTime);
            fillImage.fillAmount = currentFillAmount;
            yield return null;
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
