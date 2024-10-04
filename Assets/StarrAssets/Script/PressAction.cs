using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressAction : MonoBehaviour
{
    public GameObject particle;
    private bool isObjectClicked;

    [Header("Global Variable")]
    public static bool isButtonPressed;
    public static PressAction instance;

    void OnMouseDown()
    {
        isObjectClicked = true;
        if (!Timer.isLimitReached)
        {
            Timer.isTimerActive = true;
        }
        else
        {
            Timer.isTimerActive = false;
        }

    }

    void OnMouseUp()
    {
        isObjectClicked = false;
    }

    void Update()
    {
        isButtonPressed = isObjectClicked ? true : false;

        if (isButtonPressed && !Timer.isLimitReached)
        {
            SpawnParticle();
        }
    }

    void SpawnParticle()
    {
        Instantiate(particle, new Vector3(0, 3, 0), transform.rotation);
    }
}
