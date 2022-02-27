using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBAlloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5,50),10,0);
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }

}
