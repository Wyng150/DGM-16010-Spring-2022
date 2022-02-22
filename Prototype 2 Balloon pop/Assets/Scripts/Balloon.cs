using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; //score for popped balloon
    public int clickToPop = 3; //clicks until balloon pops
    public float inflation = 0.10f;
    public ScoreManager scoreManager; // a variable to reference score manager script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; //reduced clicks by one

        transform.localScale += Vector3.one * inflation;

        if(clickToPop == 0);
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
        
    }
}
