using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much like the Start() and Update() methods, OnTriggerEnter2D is a specail Unity method that is called
    //by Unity automatically at a specific point - in this case, when something enters the Trigger attached
    //to this GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the GameObhjects that has collided with our trigger is tagged with CleanUp...
        if (collision.gameObject.tag == "CleanUp")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
