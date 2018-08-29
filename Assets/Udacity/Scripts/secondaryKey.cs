using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondaryKey : MonoBehaviour
{
    //Create a reference to the KeyPoofPrefab and Door
    // public Door door;
    public GameObject keyPoof;
    public secondaryDoor secondDoor;
    bool locked = true;
    bool close = true;
    bool secondKeyCollected;

    public static bool gotSecondKey { get; internal set; }

    void Update()
    {
        //Not required, but for fun why not try adding a Key Floating Animation here :)
    }

    public void OnKeyClicked()
    {
        // Instatiate the KeyPoof Prefab where this key is located
        Instantiate(keyPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f));

        // Make sure the poof animates vertically
        // Instantiate(keyPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f));

        // Call the Unlock() method on the Door
        secondDoor.GetComponent<secondaryDoor>().Unlock();

        // Set the Key Collected Variable to true
        gotSecondKey = true;

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

    internal void Unlock()
    {
        throw new NotImplementedException();
    }
}
