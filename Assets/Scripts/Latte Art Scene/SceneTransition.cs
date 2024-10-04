using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneTransition : MonoBehaviour
{
    [Tooltip("Pick 1 for transitioning in, -1 for transitioning out")]
    public int direction = 1;

    [SerializeField]
    private Material screenTransitionMaterial;
    [SerializeField]
    private float transitionTime = 1f;
    [SerializeField]
    private string propertyName = "_Progress";

    private float currentTime;
    public UnityEvent OnTransitionDone;


    void Start() {
        TransitionIn();
    }

    private IEnumerator TransitionCoroutine() 
    {
        
        while (currentTime < transitionTime || currentTime >= 0) 
        {
            currentTime += Time.deltaTime * direction;
            screenTransitionMaterial.SetFloat(propertyName, Mathf.Clamp01(currentTime/transitionTime));
            yield return null;
        }
        OnTransitionDone?.Invoke();
    }

    public void TransitionIn() {
        screenTransitionMaterial.SetFloat(propertyName, 0f);
        currentTime = 0f;
        direction = 1;
        StartCoroutine(TransitionCoroutine());
    }

    public void TransitionOut() {
        screenTransitionMaterial.SetFloat(propertyName, 1f);
        currentTime = 1f;
        direction = -1;
        StartCoroutine(TransitionCoroutine());
    }
}
