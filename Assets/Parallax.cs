using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player; //Reference to the player so we can track its position
    Renderer rend; //Reference to the Renderer so we can modify its texture

    float playerStartPos; //Float used to track the starting position of the player
    public float speed = 0.5f; //How fast should each frame scroll you can change it here

    void Start()
    {
        player = GameObject.Find("Player"); //Find the player
        rend = GetComponent<Renderer>(); //Save our starting position
        playerStartPos = player.transform.position.x; //save our starting position
    }

    // Update is called once per frame
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;
        //^^^^^^^^^^^^^^^^^^^^This line finds out much to offset the texture by.
        //We do this by subtracting our starting X position from our current X position
        //We then multiply the offset by the speed, so that we can have different layers
        //moving at different speeds

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
        //^^^^^^^^^^^^^^^^^^^^^This line sets our texture 'offset'. We use the
        //SetTextureOffset method to do this, with takes 2 parameters.
        //The first parameter is a string that refers to the texture we want to modify
        //The second parameter is a Vector2, with the first (x) variable shifting the texture
        //left and right, and the second (Y) variable shifting the texture up and down
    }
}
