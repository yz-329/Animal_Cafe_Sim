using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    [Tooltip("if you go into File>Build Settings, you can view the integer code for the different scenes! the example level is 1.")]
    public int gameStartScene;
    
    public void StartGame()
    {
        // change this to a coroutine which does a switching screen animation...
        StartCoroutine(DelayedLoad());
    }

    IEnumerator DelayedLoad() 
    {
        //Wait until clip finish playing
        yield return new WaitForSeconds(1);  

        // perhaps add a loading animation
        
        // load the main game scene
        SceneManager.LoadScene(gameStartScene);
    }
}
