using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuitGameButton : MonoBehaviour
{
    public void QuitGame() {
        Debug.Log("Game has been quit");
        StartCoroutine(DelayedQuit());
    }

    IEnumerator DelayedQuit() {
        //Wait until clip finish playing
        yield return new WaitForSeconds(1);  

        // perhaps add a transition/fade animation

        Application.Quit();
    }
}
