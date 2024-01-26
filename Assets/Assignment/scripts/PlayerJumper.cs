using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    public int jumpforce = 10;
    public Rigidbody2D rb2D;
    Vector2 direction;
    void Start()
    {
        direction = new Vector2(rb2D.velocity.x, 1 * jumpforce);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb2D.AddForce(new Vector2(rb2D.velocity.x, jumpforce));

        }
      
    }
}
