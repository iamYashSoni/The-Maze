using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Door secondDoor;
    public GameObject coinPoof;

    bool locked = true;

    //Create a reference to the CoinPoofPrefab

    public void OnCoinClicked()
    {

        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        Instantiate(coinPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f));

        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);

        // Open Secondary door that leads to key on click
        


    }

}
