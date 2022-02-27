using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = {"Mike", "Chris", "Steve", "Quigs", "Collin", "Jeppo", "Janelle", "Jordan"};
    public int[] numbers = {1, 15, 69, 42, 100, 109938533, 234,};
    public int[] balloonPrefabs = {0,1,2};
    public string[] vanhalenSongs = {"Jump", "Hot for Teacer", "Panama"};
    public string[] knightsOfTheRound = {"Lancelot", "Galahad", "Gawain"};
    public string[] colors = {"Red", "Blue", "Magenta"};
    public string[] horrorMonsters = {"Freddy", "Dracula", "Annabelle"};
    public string[] favoriteMovies = {"Casablanca", "Godfather","Captain America: the Winter Soldier"};




    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(friendNames[0]);
        friendNames;  
        
        Debug.Log(vanhalenSongs[0]);
        vanhalenSongs;  

        Debug.Log(knightsOfTheRound[0]);
        knightsOfTheRound; 

        Debug.Log(horrorMonsters[0]);
        horrorMonsters; 

        Debug.Log(favoriteMovies[0]);
        favoriteMovies; 


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
