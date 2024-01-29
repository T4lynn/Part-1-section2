using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    //the direction the player is moving in
    Vector2 direction;
    //the speed the player is moving at
    public float speed = 10;
   public Rigidbody2D rb2D;
    //the directional keys pressed (is either 1 or -1 or 0)
    float moveinput;
    float maxspeed = 7;
    void Start()
    {
         
       rb2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        //direction is intialized in update, so that the y velocity updates
        direction = new Vector2(speed, rb2D.velocity.y);
        //here, moveinput must update in order to respond to player input.
        moveinput = Input.GetAxis("Horizontal");
        //adds a force that will be the speed, by the moveinput, and in forcemode impulse
        rb2D.AddForce(direction * moveinput, ForceMode2D.Impulse);
        if (rb2D.velocity.x > maxspeed)
        {
            rb2D.velocity = new Vector2(maxspeed, rb2D.velocity.y);
        } else if (rb2D.velocity.x < -maxspeed)
        {
            rb2D.velocity = new Vector2(-maxspeed, rb2D.velocity.y);
        }
        

    }
}
