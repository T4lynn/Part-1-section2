using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    Vector2 upwards;
    public Rigidbody2D rb2D;
    Vector2 direction;
    public float jumpforce;
    void Start()
    {
        jumpforce = 10;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            upwards = new Vector2(rb2D.velocity.x, jumpforce);
            Debug.Log("SPACE PRESSED");
            rb2D.AddForce(upwards, ForceMode2D.Impulse);
        }

    }
}
