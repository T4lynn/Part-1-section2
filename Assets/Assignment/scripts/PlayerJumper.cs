using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    //vector that stores jumpforce, but maintains the left/right velocity
    Vector2 upwards;
    //rigidbody
    public Rigidbody2D rb2D;
    //the force of the jump
    public float jumpforce;
    //a bool that keeps track of whether the player has an y velocity
   public bool movingup = false;
    float maxspeed = 7;
    void Start()
    {
        jumpforce = 5;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
       //listens for both a space press and if the moving up bool is false
        if (Input.GetKey(KeyCode.Space) && movingup == false)
        {
            //initalizes upwards, so that it updates the rb's x velocity.
            upwards = new Vector2(rb2D.velocity.x, jumpforce);
            Debug.Log("SPACE PRESSED");
            //adds an upward force (the v2 upwards), with an impulse forcemode. 
            rb2D.AddForce(upwards, ForceMode2D.Impulse);
        }
        //changes movingup bool from true to false depending on the y velocity.
        if (rb2D.velocity.y <= 0 )
        {
            movingup = false;
        }
        else
        {
            movingup = true;
        }
        //maximises the top speed in the y axis
        if (rb2D.velocity.y > maxspeed)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, maxspeed);
        }
        else if (rb2D.velocity.y < -maxspeed)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, - maxspeed);
        }
        //maxes the angular velocity
        if (rb2D.angularVelocity > maxspeed)
        {
            rb2D.angularVelocity = maxspeed;
        }
        else if (rb2D.angularVelocity < -maxspeed)
        {
            rb2D.angularVelocity = -maxspeed;
        }
    }
}
