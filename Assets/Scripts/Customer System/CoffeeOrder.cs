using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// stores each of the types and their respective difficulties
// someone choose the difficulties i chose them at random lol
public enum LatteArtType {
    Wavy = 4,
    Spiral = 4,
    Heart = 3,
    Star = 5,
    Flower = 6,
    Circle = 2
}


public class CoffeeOrder
{
    public List<string> toppingsMenu = new List<string>{"Vanilla", "Hazelnut", "Chocolate"};
    public int numberOfShots;
    public LatteArtType latteArtType;
    public List<string> toppingsList = new List<string>();
    // may change it to a customisation type

    public CoffeeOrder() {
        // randomly generates a coffee order
        // pick either 1 or 2 coffee shots (currently not in use)
        numberOfShots = UnityEngine.Random.Range(1,3);

        // choose a random latteArt design!
        Array types = Enum.GetValues(typeof(LatteArtType));
        latteArtType = (LatteArtType) types.GetValue(UnityEngine.Random.Range(0,6));
        
        // pick number of toppings, and select them from the toppingsMenu
        int numToppings = UnityEngine.Random.Range(0,4);
        for (int i = 0; i < numToppings; i++) {
            int randomIndex = UnityEngine.Random.Range(0,toppingsMenu.Count);
            toppingsList.Add(toppingsMenu[randomIndex]);
        }

        // I think the notepad needs to have a reference to the current customer, which then accesses this!
    }
}
