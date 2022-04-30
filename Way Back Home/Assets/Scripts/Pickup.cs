using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {redKey, blueKey, greenKey, silverKey, goldKey};
    public PickupType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.redKey)
            {
                playerController.redKey = pickupAmount;

                Debug.Log("Hey, you found the red key!");
            }
            else if(currentPickup == PickupType.blueKey)
            {
                 playerController.blueKey = pickupAmount;

                Debug.Log("Hey, you found the blue key!");
            }
            else if(currentPickup == PickupType.greenKey)
            {
                 playerController.greenKey = pickupAmount;

                Debug.Log("Hey, you found the green key!");
            }
            else if(currentPickup == PickupType.silverKey)
            {
                 playerController.silverKey = pickupAmount;

                Debug.Log("Hey, you found the silver key!");
            }
            else if(currentPickup == PickupType.goldKey)
            {
                 playerController.goldKey = pickupAmount;

                Debug.Log("Hey, you found the gold key!");
            }

           Destroy(gameObject);
            
        }    
    }
}
