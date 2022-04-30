using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverDoor : MonoBehaviour
{
       private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerController.silverKey ==1)
        {
            Debug.Log("The Door is opened.");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("You need a silver key to get through here.");
        }
    }

   
}
