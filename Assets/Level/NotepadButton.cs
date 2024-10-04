using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class NotepadButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // required interface when using the OnPointerDown method.
{
    public GameObject notepadGUI;
    public CustomText shotsText;
    public CustomText toppingsText;
    public CustomText latteArtText;
    public void OnPointerDown(PointerEventData eventData) 
    {
        // Debug.Log("Notepad button was pressed");
        // Debug.Log("MORNING!");
        shotsText.SetCustomTextShots();
        toppingsText.SetCustomTextToppings();
        latteArtText.SetCustomTextLatteArtPattern();

        notepadGUI.SetActive(true);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Debug.Log("Notepad button was released");
        notepadGUI.SetActive(false);
    }
}
