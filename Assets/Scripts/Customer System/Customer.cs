using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : ScriptableObject
{
    public CoffeeOrder coffeeOrder;

    float coffeeScore = 0f;
    float latteArtScore = 0f;
    int toppingsScore = 0;

    private GameObject customerObject;
    private Sprite customerSprite;
    // has to be customersprites IN the resources folder!
    Array objectsArray = Resources.LoadAll("CustomerSprites", typeof(Sprite));


    public Customer() {
        coffeeOrder = new CoffeeOrder();

        // pick a random sprite from a folder of sprites
        customerSprite = (Sprite) objectsArray.GetValue(UnityEngine.Random.Range(0,objectsArray.Length));

        customerObject = new GameObject("Customer");
        customerObject.transform.position = new Vector3(0,0,-5);
        SpriteRenderer renderer = customerObject.AddComponent<SpriteRenderer>();
        renderer.sprite = customerSprite;
        renderer.enabled = false;
    }    

    public void EnableSprite() {
        customerObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void DisableSprite() {
        customerObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public int getNumShots() {
        return coffeeOrder.numberOfShots;
    }

    public string getToppings() {
        // turn the array into a list here!
        return string.Join(", ",coffeeOrder.toppingsList);
    }

    public string getLatteArtType() {
        return coffeeOrder.latteArtType.ToString();
    }
}


