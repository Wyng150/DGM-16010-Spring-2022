using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Mike", "Chris", "Steve", "Quigs", "Collin", "Jeppo", "Janelle", "Jordan"};
    public int[] numbers = {1, 15, 69, 42, 100, 109938533, 234,};
    public int[] balloonPrefabs = {0,1,2};

    // Start is called before the first frame update
    void Start()
    {

        /*Debug.Log(friendNames[0]);
        friendNames;  */
        foreach(int numbers in numbers)
      
        {
            print(numbers);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
