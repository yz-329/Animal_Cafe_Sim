using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk_Jug_Script : MonoBehaviour
{
    public GameObject Latte_Art_Canvas;

    void Start()
    {
        Latte_Art_Canvas.SetActive(false);
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked!");
        Latte_Art_Canvas.SetActive(true);
    }

}

