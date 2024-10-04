using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomText : MonoBehaviour
{
    public CustomerHandler customerHandler;

    public void SetCustomTextShots() {
        Debug.Log(customerHandler.currentCustomer.getNumShots());
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText("Shots: {0}", customerHandler.currentCustomer.getNumShots());
    }

    public void SetCustomTextToppings() {
        Debug.Log(customerHandler.currentCustomer.getToppings());
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText(customerHandler.currentCustomer.getToppings());
    }

    public void SetCustomTextLatteArtPattern() {
        Debug.Log(customerHandler.currentCustomer.getLatteArtType());
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText(customerHandler.currentCustomer.getLatteArtType());
    }
}
