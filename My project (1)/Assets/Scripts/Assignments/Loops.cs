using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //public int numEwoks = 0;
    //public int ducksInPond = 30;
    public int starsInSky = 999290;
    public int avengersBlippedByThanos = 30;
    public int butthurtDceuFans = 1000000;
    public int peopleShotForTalkingDuringTheMovie = 10;
    public int pokemonCaught = 890;
    public int loopsInTheScript = 10;
    public int studentsInSchool = 200;
    public int lightBulbsBurnedOut = 300;



    // Start is called before the first frame update
    void Start()
    {
        /*while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown the coop.");
            ducksInPond --;
        }
        
        for(int i = 99; i >= numEwoks; i--)
        {
            Debug.Log("There are " + i + " Ewoks on a log.");

        }
        */
        for(int i = 999290; i <= starsInSky; i++)
        {
            Debug.Log("There are " + i + "stars in the sky");
        }
        for(int i = 30; i <= avengersBlippedByThanos; i++)
        {
            Debug.Log("There have been " + i + "Avengers dusted.");
        }
        for(int i = 1000000; i <= butthurtDceuFans; i++)
        {
            Debug.Log("There are " + i + " men crying over a billionaire in a batsuit.");
        }
        for(int i = 10; i <= peopleShotForTalkingDuringTheMovie; i++)
        {
            Debug.Log("I have shot  " + i + " people for talking duting the movie.");
        }
        for(int i = 890; i <= pokemonCaught; i++)
        {
            Debug.Log("There are " + i + " pokemon caught.");
        }
        for(int i = 10; i <= loopsInTheScript; i++)
        {
            Debug.Log("There are " + i + " loops in this script.");
        }
        for(int i = 200; i <= studentsInSchool; i++)
        {
            Debug.Log("There are " + i + " students in this school");
        }
        for(int i = 300; i <= lightBulbsBurnedOut; i++)
        {
            Debug.Log("There are " + i + "light bulbs that need replacing.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
