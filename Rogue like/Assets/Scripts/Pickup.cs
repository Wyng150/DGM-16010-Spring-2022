using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};
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
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pickupAmount;

                Debug.Log("Hey, you found the key!");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins += pickupAmount;
                Debug.Log("You foud" + pickupAmount + "Coins");
            }
            else if(currentPickup == PickupType.Gem)
            {
                playerController.gems += pickupAmount;
                Debug.Log("You found" + pickupAmount + "Gems");
            }
            Destroy(gameObject);
            
        }    
    }
}
