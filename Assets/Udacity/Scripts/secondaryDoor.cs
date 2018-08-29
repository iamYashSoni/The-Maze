using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondaryDoor : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    
    public AudioSource secondDoorSound;
    public AudioClip secondDoorLocked;
    public AudioClip secondDoorUnlocked;
    public secondaryKey secondKey; 
    private bool locked;
    private bool gotSecondKey;

    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening;



    void Start()
    {
        locked = true;         
    }

    public void OnSecondDoorClicked()

    {
        // If the door is clicked and unlocked

        //if (Key.gotKey == true)
        //    {
        // transform.Translate(0, 8f, 0);

        // transform.Translate(0, 8f * Time.deltaTime, 0, Space.World);

        //     }

        //if (locked == false)
        //{
        //    transform.Translate(0, 8f * Time.deltaTime, 0, Space.World);
        //}

        if (secondaryKey.gotSecondKey == true)
        {
            locked = false;
        }

        // (optionally) Else
        else
        {
            // Play a sound to indicate the door is locked
            secondDoorSound.PlayOneShot(secondDoorLocked);
        }

        // Set the "opening" boolean to true
        opening = true;

    }

    void Update()
    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (locked == false)
        {

            //if (transform.position.y <= 20.5f)
            //{
            //    transform.Translate(0, 4f * Time.deltaTime, 0, Space.World);
            //}

            Destroy(gameObject);

            secondDoorSound.PlayOneShot(secondDoorUnlocked);

        }
        
    }




    public void Unlock()
            {
                // You'll need to set "locked" to false here
                bool locked = false;
            }

}
