using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private YouWin winScript;
    [SerializeField] private TextMeshProUGUI winScreenText;
    private float currentTime;
   // private bool timerOn;
    void Update()
    {
        if (!winScript.win) currentTime += Time.deltaTime;

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        text.text = time.Minutes + ":" + time.Seconds;
        
        winScreenText.text = text.text;

      
       
    }
    
}
