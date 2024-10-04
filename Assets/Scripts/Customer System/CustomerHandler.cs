using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerHandler : MonoBehaviour
{
    List<Customer> customerList = new List<Customer>();
    public Customer currentCustomer;
    public GameObject endCanvas;
    // public bool testVisible = false;
    public float score = 0f;
    
    // references to the different game components
    public GameObject coffeePourStation;
    public GameObject toppingsStation;
    public GameObject latteArtStation;




    void Start()
    {
        // create a random list 3-4 of customers for this 'day'
        endCanvas.SetActive(false);
        CreateCustomers();

        Debug.Log(customerList);

        // pick a customer to start with, and remove it from the list
        currentCustomer = customerList[0];
        customerList.RemoveAt(0);
        DisplayCurrentCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        if (AllCustomersComplete()) 
        {
            // end the day
            // display the end of day canvas, which has a recap of number of customers, total points earned, and a grade?
            // option to play another day or quit to main menu
            endCanvas.SetActive(true);
        } 
        
    }

    private void DisplayCurrentCustomer() 
    {
        currentCustomer.EnableSprite();
    }

    bool AllCustomersComplete() 
    {
        return customerList.Count == 0;
    }

    public void CustomerComplete() {
        // add the score from this customer to the total
        // score += coffeePour.GetPoints();
        // score += toppingsStation.GetPoints();
        // score += latteArtStation.GetPoints();
        score += 1;

        // make the current customer disappear
        currentCustomer.DisableSprite();

        // pick the next customer, and remove the old from the list
        currentCustomer = customerList[0];
        customerList.RemoveAt(0);
        DisplayCurrentCustomer();
    }

    void CreateCustomers()
    {
        int numCustomers = Random.Range(3,6);

        for (int i = 0; i < numCustomers; i++)
        {
            // why does the code not excecute the next line
            customerList.Add(new Customer());
        }
    }
}
