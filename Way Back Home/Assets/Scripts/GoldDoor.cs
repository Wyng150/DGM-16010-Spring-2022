using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDoor : MonoBehaviour
{
      private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerController.goldKey ==1)
        {
            Debug.Log("Welcome Home.");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Seek out the Gold Key to open this door.");
        }
    }

   
}
