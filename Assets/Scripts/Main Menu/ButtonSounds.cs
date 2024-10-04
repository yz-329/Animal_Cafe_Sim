using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource clickSound;
    public AudioSource hoverSound;
    public void Click()
    {
        clickSound.Play();
    }
}
