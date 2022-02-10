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
        Add();
        Sub();
        Mult();
        Divi();
    }
         

    // Update is called once per frame
    void Update()
    {
        
    }

    void Add()
    {
        int total;
        total = numberA + numberB;
        Debug.Log(numberA +" + "+ numberB +" = "+ total);
    }
    void Sub()
    {
        int total;
        total = numberB - numberC;
        Debug.Log(numberB +" - "+ numberC +" = "+ total);
    }
    void Mult()
    {
        int total;
        total = numberB * numberB;
        Debug.Log(numberB +" X "+ numberB +" = "+ total);
    
    }
    void Divi()
    {
        int total;
        total = numberC / numberA;
        Debug.Log(numberC +" / "+ numberA +" = "+ total);
    
    }
}
