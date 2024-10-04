using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeVolume : MonoBehaviour
{
    /*
    public Enum Lights 
    {
        air,
        Great,
        Excellent
    };

    public GameObject greenC;
    public GameObject orangeC;
    public GameObject redC;
    public int d;
    */

    [Header("Scale Measures")]
    public float scaleSpeed;
    public float minScale;
    public float maxScale;

    public bool isScaling = false;
    private float yScale = 0.5f;
    private Vector3 initialScale;

    // public Lights image = Lights.Fair; 


    void Start()
    {
        initialScale = transform.localScale; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.isTimerActive)
        {
            if (PressAction.isButtonPressed)
            {
                isScaling = true;
            }
            else if (PressAction.isButtonPressed == false)
            {
                isScaling = false;
            }
        }
        else if (!Timer.isTimerActive)
        {
            isScaling = false;
        }
        
        if (isScaling)
        {
            yScale += scaleSpeed * Time.deltaTime;

            // Clamp the scale within the min/max range
            yScale = Mathf.Clamp(yScale, minScale, maxScale);

            // Calculate the new scale vector
            Vector3 newScale = new Vector3(initialScale.x, yScale, initialScale.z);

            // Only apply the new scale vector if it is larger than the current scale vector
            if (newScale.y > transform.localScale.y)
            {
                transform.localScale = newScale;
            }
        }
    }
    /*
    if (timerScript.isLimitReached) 
    {
        switch (image)
        {
            case Fair:
                redC.SetActive(true);
                break;
            case Great:
                orangeC.SetActive(true);
                break;
            case Excellent:
                greenC.SetActive(true);
                break;
        }
    }
    */
}
