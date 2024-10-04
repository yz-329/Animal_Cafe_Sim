using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown; //default == false

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;
    public string timerFormat;

    [Header("Global Variables")]
    public static bool isLimitReached;
    public static bool isTimerActive;
    public static Timer instance;

    // Update is called once per frame
    void Update()
    {

        if (isTimerActive)
        {
            StartTimer();
        }
        SetTimerText(); 

        if (timerText.text == "0.00")
        {
            isLimitReached = true;
        }

    }

    public void SetTimerText()
    { // each timer text will be updated that matches currentTime 
        timerText.text = currentTime.ToString(timerFormat);
    }

    public void StartTimer()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red; //change timer apperance command
            // isTimerActive = false;
            // enabled = false; //stops running   
        }
    }


}


