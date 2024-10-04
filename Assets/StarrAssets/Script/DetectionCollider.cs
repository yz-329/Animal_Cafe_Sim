using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCollider : MonoBehaviour
{
    public GameObject popUpText;
    public bool isTriggered;
    
    // Start is called before the first frame update

    void Start()
    {
        popUpText.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer.isLimitReached && isTriggered)
        {
            popUpText.SetActive(true);
        }
        else
        {
            popUpText.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("ENTEREDUPPER FAIR");
        isTriggered = true;
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("exit");
        isTriggered = false;
    }


    /*
    public void OnTriggerEnter2D(Collider2D col)
    {
        CoffeeVolume cv = CoffeeFill.GetComponent<CoffeeVolume>();
        cv.image = imageNumber; 

        Debug.Log("COLLISION");
        Debug.Log(timerScript.isLimitReached);
        if (timerScript.isLimitReached)
        { 
            Debug.Log("TIMER DONEEEE");
            circle.SetActive(true);
            
            popUpText.SetActive (true);
        }
    }
    */

}
