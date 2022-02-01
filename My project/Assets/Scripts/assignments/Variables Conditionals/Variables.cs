using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Global Variables can be accessed from other scripts
    public int money; //Whole number value 2, 14, 57, -92, 69, -100
    public float change = 0.75f; // Floating point number or decimal 3.15, 105.22, 0.13
    public bool isDay = true; //Booleans are true or false
    private string firstName ;//String are alpha numeric text contained in quotation marks
    
        // Start is called before the first frame update
    void Start()
    {
        money = 125;
        Debug.Log("Money in account = $" + money); 
        // Local Variable
        
    }

    // Update is called once per frame
    void Update()
    {
       if(change <= 1.00f)
       {
           print("Not enough cash, Stranger!");
        
       }
       else if(change > 1.00f)
       {
           print("Shut up and take my money!");
       }

    }
}
