using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{
    // Access Modifier DataType Name = Value
    public int numberA = 10;
    public int numberB = 20;
    public int numberC = 30;
    // Start is called before the first frame update
    void Start()
    {
        int total;

        total = numberA + numberB;

        Debug.Log(numberA + " + " + numberB + " = " + total);
            }

    // Update is called once per frame
    void Update()
    {
        
    }
}
