using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float starWaitTime;
    public Transform StartPoint;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    // Start is called before the first frame update
    void Start()
    {
        waitTime = starWaitTime;
        StartPoint.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, StartPoint.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, StartPoint.position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                StartPoint.position = new Vector2(Random.Range(minX,maxX), Random.Range(minY,maxY));
                waitTime = starWaitTime;
            }
            else
            {
                waitTime = Time.deltaTime;
            }
        }
    }
}
