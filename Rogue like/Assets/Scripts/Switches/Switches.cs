using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;
    public int socialClass = 1;

    void Start()
    {
        switch(npcConv)
        {
            case "Hello":
             print("Hello, retard! Who told you that you could talk to me?");
             break;
            case "Goodbye":
             print("Thanks for wasting my time. Stupid player");
             break;
            case "We are under attack!":
             print("Well, who's fault it that, I wonder?");
             break;

        }
        

        /*switch(socialClass)
        {
            case 5:
            Debug.Log("Hello, Mr. Bill Murray!");
            break;
            case 4:
            Debug.Log("Hello, Harold Ramis.");
            case 3:
            Debug.Log("Hey, Mr Akroyd."); 
            case 2: 
            Debug.Log("Hello, Ernie.");
            case 1:
            Debug.Log("Shut up, Meg.");
        }
        */
    }

}
